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
    public partial class TimeTable : Form
    {
        public TimeTable(Person person)
        {
            InitializeComponent();
            if(person.level < 5)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            if (day_tb.Text.Equals("")) day_tb.Text = "%";
            if (class_tb.Text.Equals("")) class_tb.Text = "%";
            if (object_tb.Text.Equals("")) object_tb.Text = "%";
            if (cabinet_tb.Text.Equals("")) cabinet_tb.Text = "%";
            if (teacher_tb.Text.Equals("")) teacher_tb.Text = "%";
            try
            {
                this.getTimeTableTableAdapter.Fill(this.dBSchoolDataSet.getTimeTable, day_tb.Text, class_tb.Text, object_tb.Text, cabinet_tb.Text, teacher_tb.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (day_tb.Text.Equals("%")) day_tb.Text = "";
            if (class_tb.Text.Equals("%")) class_tb.Text = "";
            if (object_tb.Text.Equals("%")) object_tb.Text = "";
            if (cabinet_tb.Text.Equals("%")) cabinet_tb.Text = "";
            if (teacher_tb.Text.Equals("%")) teacher_tb.Text = "";
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getTeacher". При необходимости она может быть перемещена или удалена.
            this.getTeacherTableAdapter.Fill(this.dBSchoolDataSet.getTeacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getCabinet". При необходимости она может быть перемещена или удалена.
            this.getCabinetTableAdapter.Fill(this.dBSchoolDataSet.getCabinet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getObjects". При необходимости она может быть перемещена или удалена.
            this.getObjectsTableAdapter.Fill(this.dBSchoolDataSet.getObjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getClasses". При необходимости она может быть перемещена или удалена.
            this.getClassesTableAdapter.Fill(this.dBSchoolDataSet.getClasses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSchoolDataSet.getDays". При необходимости она может быть перемещена или удалена.
            this.getDaysTableAdapter.Fill(this.dBSchoolDataSet.getDays);

        }

        private void id_ctb_TextChanged(object sender, EventArgs e)
        {
            if(id_ctb.Text.Length > 0)
            {
                add_tt_b.Text = "Изменить";
            }
            else
            {
                add_tt_b.Text = "Добавить";
            }
        }

        private void add_tt_b_Click(object sender, EventArgs e)
        {
            WorkWithDB workWithDB = new WorkWithDB();
            int day = workWithDB.getIdBySQL($"select Дни.[Код дня] from Дни where Дни.название = '{getDaysComboBox.SelectedValue.ToString()}'");
            int classOfSchool = workWithDB.getIdBySQL($"select Классы.[Код класса] from Классы where Классы.Название = '{getClassesComboBox.SelectedValue.ToString()}'");
            int obj = workWithDB.getIdBySQL($"select Предметы.[Код предмета] from Предметы where Предметы.[название предмета] = '{getObjectsComboBox.SelectedValue.ToString()}'");
            int cabinet = workWithDB.getIdBySQL($"select Кабинеты.[Код кабинета] from Кабинеты where Кабинеты.Номер = {getCabinetComboBox.SelectedValue.ToString()}");
            int teacher = workWithDB.getIdBySQL($"select Сотрудник.id from Сотрудник where Сотрудник.Фамилия = '{getTeacherComboBox.SelectedValue.ToString()}'");
            if (add_tt_b.Text.Equals("Добавить"))
            {
                workWithDB.addTimeTable(day, classOfSchool, obj, cabinet, teacher);
                MessageBox.Show("Добавление завершено");
            }
            else
            {
                int id = -1;
                try
                {
                   id = Convert.ToInt32(id_ctb.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                workWithDB.updateTimeTable(id, day, classOfSchool, obj, cabinet, teacher);
                MessageBox.Show("Изменения сохранены");
            }
            fillToolStripButton_Click(null, null);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
            MessageBox.Show("Вы уверены что хотите удалить эту запись из расписания?", "Подтвердите", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(dialogResult.Equals(DialogResult.No) || dialogResult.Equals(DialogResult.Cancel))
            {
                return;
            }
            int id = -1;
            try
            {
                id = Convert.ToInt32(idForDelete_ctb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WorkWithDB workWithDB = new WorkWithDB();
            workWithDB.deleteFromTimeTable(id);
            MessageBox.Show("Удалено");
        }
    }
}
