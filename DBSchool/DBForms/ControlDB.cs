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
    public partial class ControlDB : Form
    {
        public ControlDB()
        {
            InitializeComponent();
        }

        private void logInBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logInBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);

        }

        private void ControlDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Журнал". При необходимости она может быть перемещена или удалена.
            this.журналTableAdapter.Fill(this.dBSchoolDataSet.Журнал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.dBSchoolDataSet.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Кабинеты". При необходимости она может быть перемещена или удалена.
            this.кабинетыTableAdapter.Fill(this.dBSchoolDataSet.Кабинеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Дни". При необходимости она может быть перемещена или удалена.
            this.дниTableAdapter.Fill(this.dBSchoolDataSet.Дни);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.dBSchoolDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet._Классные_рук_ли". При необходимости она может быть перемещена или удалена.
            this.классные_рук_лиTableAdapter.Fill(this.dBSchoolDataSet._Классные_рук_ли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Классы". При необходимости она может быть перемещена или удалена.
            this.классыTableAdapter.Fill(this.dBSchoolDataSet.Классы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.dBSchoolDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.dBSchoolDataSet.Родители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.dBSchoolDataSet.Учащийся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.dBSchoolDataSet.Person);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.LogIn". При необходимости она может быть перемещена или удалена.
            this.logInTableAdapter.Fill(this.dBSchoolDataSet.LogIn);
        }

        private void logInBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.logInBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учащийсяBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.родителиBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.классыBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton42_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.классные_рук_лиBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton49_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton56_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дниBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton63_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кабинетыBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton70_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.расписаниеBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton77_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журналBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dBSchoolDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

