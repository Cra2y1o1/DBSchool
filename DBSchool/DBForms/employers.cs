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
    public partial class employers : Form
    {
        public employers()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            if (Position_tb.Text.Equals("")) Position_tb.Text = "%";
            if (Familiya_tb.Text.Equals("")) Familiya_tb.Text = "%";
            try
            {
                this.getEmployersByPosFamilTableAdapter.Fill(this.dBSchoolDataSet.getEmployersByPosFamil, Position_tb.Text, Familiya_tb.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Position_tb.Text = "";
            Familiya_tb.Text = "";
        }
    }
}
