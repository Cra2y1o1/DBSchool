using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSchool.DBForms
{
    public partial class Studiers : Form
    {
        public Studiers()
        {
            InitializeComponent();
        }


        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            if (ClassName_tb.Text.Equals("")) ClassName_tb.Text = "%";
            if (LastName_tb.Text.Equals("")) LastName_tb.Text = "%";
            try
            {
                this.getPeopleByClassTableAdapter.Fill(this.dBSchoolDataSet.getPeopleByClass, ClassName_tb.Text, LastName_tb.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (ClassName_tb.Text.Equals("%")) ClassName_tb.Text = "";
            if (LastName_tb.Text.Equals("%")) LastName_tb.Text = "";

        }
    }
}
