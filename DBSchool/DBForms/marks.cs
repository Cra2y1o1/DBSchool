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
    public partial class marks : Form
    {
        Person Im;
        public marks(object person)
        {
            InitializeComponent();
            Im = (Person)person;
            if (Im.level == 1)
            {
                lastName_st_tb.Text = Im.lastName;
                lastName_st_tb.Enabled = false;
            }
            if(Im.level < 4)
            {
                groupBox2.Enabled = false;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            if (lastName_st_tb.Text.Equals("")) lastName_st_tb.Text = "%";
            if (NameObject_tb.Text.Equals("")) NameObject_tb.Text = "%";
            if (LastName_tc_tb.Text.Equals("")) LastName_tc_tb.Text = "%";
            if (idMark_tb.Text.Equals("")) idMark_tb.Text = "%";
            try
            {
                this.getMarkTableAdapter.Fill(this.dBSchoolDataSet.getMark, lastName_st_tb.Text, NameObject_tb.Text, LastName_tc_tb.Text, idMark_tb.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (lastName_st_tb.Text.Equals("%")) lastName_st_tb.Text = "";
            if (NameObject_tb.Text.Equals("%")) NameObject_tb.Text = "";
            if (LastName_tc_tb.Text.Equals("%")) LastName_tc_tb.Text = "";
            if (idMark_tb.Text.Equals("%")) idMark_tb.Text = "";
        }

        private void marks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getObjects". При необходимости она может быть перемещена или удалена.
            this.getObjectsTableAdapter.Fill(this.dBSchoolDataSet.getObjects);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            int int_mark = -1;
            WorkWithDB workWithDB = new WorkWithDB();
            try
            {
                id = Convert.ToInt32(idPeople.Text);
                int_mark = Convert.ToInt32(mark.Text);
                if (int_mark < 1 || int_mark > 10) throw new Exception("Неверно задана оценка");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            workWithDB.addMark(id, getObjectsComboBox.SelectedIndex+1, Im.id, int_mark);

        }

        private void toChangeMark_Click(object sender, EventArgs e)
        {
            ChangeMark changeMark = new ChangeMark(Im);
            changeMark.ShowDialog();
        }
    }
}
