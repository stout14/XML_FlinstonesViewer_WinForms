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
    public partial class DetailForm : Form
    {
        Character _person = new Character();

        public DetailForm(Character person)
        {
            InitializeComponent();
            _person = person;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            lbl_FullName.Text = _person.FullName();
            lbl_Age.Text = _person.Age.ToString();
            lbl_Gender.Text = _person.Gender.ToString();
            lbl_Description.Text = _person.Description;
            picBox_Photo.Image = Image.FromFile(@"Images/" + _person.ImageFileName);
        }



    }
}
