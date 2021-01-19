using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSchool
{
    public partial class myAccount : Form
    {
        Person person;
        public myAccount(int id)
        {
            InitializeComponent();
            person = new Person();
            person.id = id;
        }

        private void myAccount_Load(object sender, EventArgs e)
        {
            
            WorkWithDB workWithDB = new WorkWithDB();
            person = workWithDB.getFullInformation(person.id);
            id_l.Text = person.id.ToString();
            login_l.Text = person.username;
            lvl_l.Text = person.level.ToString();

            LastName_tb.Text = person.lastName;
            Name_tb.Text = person.name;
            patr_tb.Text = person.patronymic;
            PhoneNumber_tb.Text = person.number;
            Birthday_dtp.Value =   DateTime.Parse(person.birthday);

            sex_l.Text = person.sex;
            status_l.Text = person.position;
            email_ctm.Text = person.email;
            secretWord_ctb.Text = person.secretWord;

            full_posit_l.Text = person.fullPosition == "" ? "" : "Должность: " + person.fullPosition;

        }

        private void save_b_Click(object sender, EventArgs e)
        {
            if (old_pass_ctb.Text.Equals(person.password))
            {
                Regex regex = new Regex(@"[A-Za-z0-9]+$");
                if (!regex.IsMatch(new_pass_ctb.Text))
                {
                    MessageBox.Show("Пароль должен состоять из английских букв и цифр", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!new_pass_ctb.Text.Equals(repeat_pass_tb.Text))
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(new_pass_ctb.Text.Length < 8)
                {
                    MessageBox.Show("СЛишком короткий пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                WorkWithDB work = new WorkWithDB();
                work.UpdatePassword(person.id, new_pass_ctb.Text);
            }
            else if(old_pass_ctb.Text.Length != 0)
            {
                MessageBox.Show("Введен неверный старый пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            person.lastName = LastName_tb.Text;
            person.name = Name_tb.Text;
            person.patronymic = patr_tb.Text;
            if (!PhoneNumber_tb.MaskCompleted)
            {
                MessageBox.Show("Номер телефона указан неверно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            person.number = PhoneNumber_tb.Text;

            if ((DateTime.Now.Year - Birthday_dtp.Value.Year) < 6)
            {
                MessageBox.Show("Ваш возраст слишком мал для регистрации на данном сервисе", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           person.birthday = Birthday_dtp.Value.Day + "." +
               Birthday_dtp.Value.Month + "." +
               Birthday_dtp.Value.Year;
            try
            {

                MailAddress m = new MailAddress(email_ctm.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели неверный E-mail!", "Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            person.email = email_ctm.Text;
            person.secretWord = secretWord_ctb.Text;
            WorkWithDB workWithDB = new WorkWithDB();
            if (workWithDB.updateUser(person))
            {
                this.Close();
            }
        }
    }
}
