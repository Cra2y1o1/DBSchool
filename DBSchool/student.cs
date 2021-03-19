using System;
using DBSchool.DBForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DBSchool
{
    public partial class student : Form
    {
        private Person person;
        public student(object person)
        {
            InitializeComponent();
            this.person = (Person)person;
            WorkWithDB workWithDB = new WorkWithDB();
            this.person =
           workWithDB.getFullInformation(this.person.id);
            NamePosition_l.Text = this.person.lastName + " " +
           this.person.name + ", " + this.person.position;
            //lvl_l.Text = this.person.level.ToString();
            Class_l.Text = workWithDB.getClass(this.person.id);
        }
        private void student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void MyAcc_l_Click(object sender, EventArgs e)
        {
            myAccount account = new myAccount(person.id);
            account.ShowDialog();
        }
        private void MyAcc_l_MouseEnter(object sender, EventArgs e)
        {
            MyAcc_l.ForeColor = Color.Orange;
        }
        private void MyAcc_l_MouseLeave(object sender, EventArgs e)
        {
            MyAcc_l.ForeColor = Color.Empty;
        }
        private void parents_b_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents(person.level);
            parents.ShowDialog();
        }
        private void Exit_l_Click(object sender, EventArgs e)
        {
            aunt a = new aunt();
            a.Show();
            this.Dispose();
        }
        private void Exit_l_MouseEnter(object sender, EventArgs e)
        {
            Exit_l.ForeColor = Color.Orange;
        }
        private void Exit_l_MouseLeave(object sender, EventArgs e)
        {
            Exit_l.ForeColor = Color.Empty;
        }
        private void studiers_b_Click(object sender, EventArgs e)
        {
            Studiers studiers = new Studiers();
            studiers.ShowDialog();
        }
        private void Employers_b_Click(object sender, EventArgs e)
        {
            employers emp = new employers();
            emp.ShowDialog();
        }
        private void marks_b_Click(object sender, EventArgs e)
        {
            marks marks = new marks(person);
            marks.ShowDialog();
        }
        private void toTimeTable_b_Click(object sender,EventArgs e)
        {
            TimeTable table = new TimeTable(person);
            table.ShowDialog();
        }
    }
}