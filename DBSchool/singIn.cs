using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using DBSchool.DBForms;
namespace DBSchool
{
    public partial class singIn : Form
    {
        Person somePerson = new Person();
        int stage = 1;
        public singIn()
        {
            InitializeComponent();
            updateStage();
        }
        private void updateStage()
        {
            stage_l.Text = "Этап регистрации " + stage.ToString() + "/4";
            switch (stage)
            {
                case 1:
                    {
                        Sex_cb.Visible = false;
                        Bithday_dtp.Visible = false;
                        PhoneNumber_tb.Visible = false;
                        tb_2.UseSystemPasswordChar = false;
                        tb_3.UseSystemPasswordChar = false;
                        tb_1.Visible = true;
                        tb_1.Text = somePerson.lastName;
                        tb_1.Cue = "Фамилия";
                        tb_2.Visible = true;
                        tb_2.Text = somePerson.name;
                        tb_2.Cue = "Имя";
                        tb_3.Visible = true;
                        tb_3.Text = somePerson.patronymic;
                        tb_3.Cue = "Отчество";
                        tb_3.Font = new Font("Open Sans Semibold", 24);
                        NextStep_b.Text = "ДАЛЕЕ";
                        break;
                    }
                case 2:
                    {
                        tb_1.Visible = false;
                        Sex_cb.Visible = true;
                        tb_2.UseSystemPasswordChar = false;
                        tb_3.UseSystemPasswordChar = false;
                        Sex_cb.Items.Clear();
                        Sex_cb.Items.Add("Мужской");
                        Sex_cb.Items.Add("Женский");
                        Sex_cb.Text = "Пол";
                        Sex_cb.SelectedIndex = -1;
                        tb_2.Visible = false;
                        Bithday_dtp.Visible = true;
                        Bithday_dtp.Value = somePerson.birthday != "" ? Convert.ToDateTime(somePerson.birthday) : Bithday_dtp.Value;
                        tb_3.Visible = false;
                        PhoneNumber_tb.Visible = true;
                        NextStep_b.Text = "ДАЛЕЕ";
                        break;
                    }
                case 3:
                    {
                        Bithday_dtp.Visible = false;
                        PhoneNumber_tb.Visible = false;
                        tb_2.UseSystemPasswordChar = false;
                        tb_3.UseSystemPasswordChar = false;
                        Sex_cb.Items.Clear();
                        Sex_cb.Items.Add("Учащийся");
                        Sex_cb.Items.Add("Родитель");
                        Sex_cb.Items.Add("Сотрудник");
                        Sex_cb.Text = "Должность";
                        Sex_cb.SelectedIndex = -1;
                        tb_2.Visible = true;
                        tb_2.Cue = "E-mail";
                        tb_2.Text = "";
                        tb_3.Visible = true;
                        tb_3.Text = "";
                        tb_3.Cue = "Кодовое слово";
                        tb_3.Font = new Font("Open Sans Semibold", 24);
                        NextStep_b.Text = "ДАЛЕЕ";
                        break;
                    }
                case 4:
                    {
                        Sex_cb.Visible = false;
                        Bithday_dtp.Visible = false;
                        tb_1.Visible = true;
                        tb_1.Cue = "Username";
                        tb_1.Text = "";
                        tb_2.Visible = true;
                        tb_2.Cue = "Password";
                        tb_2.Text = "";
                        tb_2.UseSystemPasswordChar = true;
                        tb_3.Visible = true;
                        tb_3.Cue = "Confirm Password";
                        tb_3.Text = "";
                        tb_3.UseSystemPasswordChar = true;
                        NextStep_b.Text = "ГОТОВО";
                        break;
                    }
            }
        }
        private void NextStep_b_Click(object sender, EventArgs
        e)
        {
            switch (stage)
            {
                case 1:
                    {
                        Regex rgx = new Regex(@"^[А-Я][ая]+$");
                        if (tb_1.Text.Length < 2)
                        {
                            MessageBox.Show("В фамилии слишком мало символов!", "Ошибка!");
                        return;
                        }
                        if (!rgx.IsMatch(tb_1.Text))
                        {
                            MessageBox.Show("В фамилии найдены неверные символы!", "Ошибка!");
                        return;
                        }
                        if (tb_2.Text.Length < 2)
                        {
                            MessageBox.Show("В имени слишком мало символов!", "Ошибка!");
                        return;
                        }
                        if (!rgx.IsMatch(tb_2.Text))
                        {
                            MessageBox.Show("В имени найдены неверные символы!", "Ошибка!");
                        return;
                        }
                        if (tb_3.Text.Length != 0)
                        {
                            if (!rgx.IsMatch(tb_3.Text))
                            {
                                MessageBox.Show("В отчестве найдены неверные символы!", "Ошибка!");
                            return;
                            }
                        }
                        somePerson.lastName = tb_1.Text;
                        somePerson.name = tb_2.Text;
                        somePerson.patronymic = tb_3.Text;
                        stage = 2;
                        updateStage();
                        break;
                    }
                case 2:
                    {
                        if (Sex_cb.SelectedIndex.Equals(-1))
                        {
                            MessageBox.Show("Вы не выбрали ваш пол!", "Ошибка!");
                        return;
                        }
                        somePerson.sex =
                    Sex_cb.SelectedItem.ToString();
                        if ((DateTime.Now.Year - Bithday_dtp.Value.Year) < 6)
                        {
                            MessageBox.Show("Ваш возраст слишком мал для регистрации на данном сервисе", "Ошибка!");
                        return;
                        }
                        somePerson.birthday =
                        Bithday_dtp.Value.Day + "." +
                         Bithday_dtp.Value.Month + "." +
                         Bithday_dtp.Value.Year;
                        if (!PhoneNumber_tb.MaskCompleted)
                        {
                            MessageBox.Show("Номер телефона это обязательное поле!", "Ошибка!");
                        return;
                        }
                        if (!PhoneNumber_tb.Text.Contains("(25)") &&
                        !PhoneNumber_tb.Text.Contains("(29)") &&
                        !PhoneNumber_tb.Text.Contains("(33)") &&
                        !PhoneNumber_tb.Text.Contains("(44)"))
                        {
                            MessageBox.Show("Нет такого кода оператора", "Ошибка!");
                        return;
                        }
                        somePerson.number =
                        PhoneNumber_tb.Text;
                        stage = 3;
                        updateStage();
                        break;
                    }
                case 3:
                    {
                        if (Sex_cb.SelectedIndex.Equals(-1))
                        {
                            MessageBox.Show("Вы не выбрали вашу должность!", "Ошибка!");
                            return;
                        }
                        somePerson.position = Sex_cb.SelectedItem.ToString();
                        somePerson.level = Sex_cb.SelectedIndex + 1;
                        try
                        {
                            MailAddress m = new
                            MailAddress(tb_2.Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Вы ввели неверный E - mail!", "Ошибка!");
                            return;
                        }
                        catch (ArgumentException)
                        {
                        }
                        somePerson.email = tb_2.Text;
                        if (tb_3.Text.Length < 2)
                        {
                            MessageBox.Show("Кодовое слово обязательно!\nоно будет использовано при утере пароля", "Ошибка!");
                            return;
                        }
                        somePerson.secretWord = tb_3.Text;
                        stage = 4;
                        updateStage();
                        break;
                    }
                case 4:
                    {
                        if (tb_1.Text.Length < 3)
                        {
                            MessageBox.Show("Username должен состоять как минимум из 3 символов");
                        return;
                        }
                        Regex regex = new Regex(@"[A-Zaz0-9]+$");
                        if (!regex.IsMatch(tb_1.Text))
                        {
                            MessageBox.Show("username долен состоять из англиских букв и цифр", "Ошибка!");
                        return;
                        }
                        somePerson.username = tb_1.Text;
                        if (tb_2.Text.Length < 8)
                        {
                            MessageBox.Show("Пароль должен содержать не менее 8 символов", "Ошибка!");
                        return;
                        }
                        if (!regex.IsMatch(tb_2.Text))
                        {
                            MessageBox.Show("Пароль долен состоять из англиских букв и цифр", "Ошибка!");
                        return;
                        }
                        if (!tb_3.Text.Equals(tb_2.Text))
                        {
                            MessageBox.Show("Пароли должны совпадать!", "Ошибка!");
                        return;
                        }
                        somePerson.password = tb_2.Text;
                        WorkWithDB workWithDB = new
                        WorkWithDB();
                        if
                        (!workWithDB.addUser(somePerson)) return;
                        if (somePerson.level == 3)
                        {
                            ChangeFullPositions
                            changeFullPositions = new ChangeFullPositions(somePerson);
                            changeFullPositions.ShowDialog();
                        }
                        else if (somePerson.level == 2)
                        {
                            MessageBox.Show("Родитель");
                        }
                        else
                        {
                            MessageBox.Show("Ученик");
                        }
                        this.Close();
                        break;
                    }
            }
        }
        #region Animation
        private void back_l_Click(object sender, EventArgs e)
        {
            if (stage != 1)
                stage--;
            updateStage();
        }
        private void back_l_MouseEnter(object sender, EventArgs e)
        {
            back_l.ForeColor = Color.Orange;
        }
        private void back_l_MouseLeave(object sender, EventArgs e)
        {
            back_l.ForeColor = Color.Black;
        }
        #endregion
        private void NextStep_b_MouseEnter(object sender, EventArgs e)
        {
            NextStep_b.BackColor = Color.Magenta;
        }
        private void NextStep_b_MouseLeave(object sender,EventArgs e)
        {
            NextStep_b.BackColor = Color.DarkMagenta;
        }
    }
}