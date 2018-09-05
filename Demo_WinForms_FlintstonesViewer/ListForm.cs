using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms_FlintstonesViewer
{
    public partial class ListForm : Form
    {
        private List<Character> _charecters;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ReadXmlFileAndBindToDataGrid()
        {
            string datafile = @"Data\FlintstoneCharacters.xml";

            //
            // read data file
            //
            IDataService dataService = new XmlDataService(datafile);
            _charecters = dataService.ReadAll();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Character>(_charecters);
            var source = new BindingSource(bindingList, null);
            dataGridView_Characters.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dataGridView_Characters.Columns["Id"].Visible = false;
            this.dataGridView_Characters.Columns["ImageFileName"].Visible = false;
            this.dataGridView_Characters.Columns["Description"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadXmlFileAndBindToDataGrid();
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
            this.Close();
        }
    }
}
