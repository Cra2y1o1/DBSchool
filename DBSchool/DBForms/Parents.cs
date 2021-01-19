using System;
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
    public partial class Parents : Form
    {
        int lvl;
        public Parents(int lvl)
        {
            InitializeComponent();
            this.lvl = lvl;
        }

        private void updateinfo()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getParets".При необходимости она может быть перемещена или удалена.
            this.getParetsTableAdapter.Fill(this.dBSchoolDataSet.getParets);
        }
        private void Parents_Load(object sender, EventArgs e)
        {
            updateinfo();
            bool permission = false;
            if (lvl > 3) permission = true;
            idParent_tb.Enabled = permission;
            idPeople_tb.Enabled = permission;
            unite_b.Enabled = permission;

            idParetn_del_tb.Enabled = permission;
            divide_b.Enabled = permission;


        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.getPeopleByFamilTableAdapter.Fill(this.dBSchoolDataSet.getPeopleByFamil, familToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void unite_b_Click(object sender, EventArgs e)
        {
            int.TryParse(idParent_tb.Text, out int idP);
            if(idP < 1)
            {
                MessageBox.Show("Неверный id Родителя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(idPeople_tb.Text, out int idС);
            if (idС < 1)
            {
                MessageBox.Show("Неверный id Ребенка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WorkWithDB workWithDB = new WorkWithDB();
            if(workWithDB.UpdateParentChild(idP, idС) == 0)
            {
                MessageBox.Show("Неудалось связать родителя и ребенка\nПроверьте данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateinfo();
            idParent_tb.Text = "";
            idPeople_tb.Text = "";
        }

        private void divide_b_Click(object sender, EventArgs e)
        {
            int.TryParse(idParetn_del_tb.Text, out int idP);
            if (idP < 1)
            {
                MessageBox.Show("Неверный id Родителя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы дейсвительно хотите отвязать ребенка от этого родителя?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!result.Equals(DialogResult.Yes)) return;
            WorkWithDB workWithDB = new WorkWithDB();
            if (workWithDB.UpdateParentChild(idP, 0) == 0)
            {
                MessageBox.Show("Неудалось связать родителя и ребенка\nПроверьте данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateinfo();
            idParetn_del_tb.Text = "";
        }
    }
}
