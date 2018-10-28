using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_WinForms_FlintstonesViewer.DAL;

namespace Demo_WinForms_FlintstonesViewer
{
    public partial class ListForm : Form
    {
        string searchTerm = "";
        string catagorySearchTerm = "";
        
        private List<Character> _characters;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ReadXmlFileAndBindToDataGrid()
        {
            string dataFilePath = AppConfig.dataFilePath;

            //
            // read data file
            //
            IDataService dataService = new MongoDBDataService();
            _characters = dataService.ReadAll() as List<Character>;

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Character>(_characters);
            var source = new BindingSource(bindingList, null);
            dataGridView_Characters.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dataGridView_Characters.Columns["Id"].Visible = true;
            this.dataGridView_Characters.Columns["ImageFileName"].Visible = false;
            this.dataGridView_Characters.Columns["Description"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ReadXmlFileAndBindToDataGrid();
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Unable to locate data file.\nExiting the application.");
                this.Close();
            }

        }

        private void btn_CheckList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Characters.SelectedRows)
            {
                dataGridView_Characters.Rows.RemoveAt(row.Index);
            }
        }

        private void btn_DetailView_Click(object sender, EventArgs e)
        {
            if (dataGridView_Characters.SelectedRows.Count == 1)
            {
                Character character = new Character();
                character = (Character)dataGridView_Characters.CurrentRow.DataBoundItem;

                DetailForm detailForm = new DetailForm(character);
                detailForm.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                IDataService MongoDBDataService = new MongoDBDataService();
                MongoDBDataService.WriteAll(_characters);
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();

        }

        private void button_OrderByAge_Click(object sender, EventArgs e)
        {
            var sortedList = _characters.OrderBy(c => c.Age).ToList();
            dataGridView_Characters.DataSource = sortedList;
        }


        private void button_OrderByName_Click(object sender, EventArgs e)
        {
            var sortedList = _characters.OrderBy(c => c.FirstName).ToList();
            dataGridView_Characters.DataSource = sortedList;
        }

        private void button_OrderByID_Click(object sender, EventArgs e)
        {
            var sortedList = _characters.OrderBy(c => c.Id).ToList();
            dataGridView_Characters.DataSource = sortedList;
        }

        private void button_FilterByMale_click(object sender, EventArgs e)
        {
            var filteredList = _characters.Where(c => c.Gender == Character.GenderType.Male).ToList();
            dataGridView_Characters.DataSource = filteredList;
        }

        private void button_FilterByFemale_click(object sender, EventArgs e)
        {
            var filteredList = _characters.Where(c => c.Gender == Character.GenderType.Female).ToList();
            dataGridView_Characters.DataSource = filteredList;
        }



        private void textbox_pressEnter(object sender, KeyPressEventArgs e)
        {
            searchTerm = SearchTextBox.Text;
            
            if (e.KeyChar == 13)
            {
                e.Handled = true; // this stops the application from dinging at you when pressing enter
                var searchedList = _characters.Where(c => c.LastName.ToUpper().Contains(searchTerm.ToUpper())).ToList();
                dataGridView_Characters.DataSource = searchedList;
            }
            
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //messing with this
        }

        private void button_search_click(object sender, EventArgs e)
        {            
            var searchedList = _characters.Where(c => c.LastName.ToUpper().Contains(searchTerm.ToUpper())).ToList();
            dataGridView_Characters.DataSource = searchedList;
        }

        private void button_help_click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
