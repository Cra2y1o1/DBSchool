using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DBSchool
{
    public partial class aunt : Form
    {
        SqlConnection sqlConnection;
        List<Person> Persons;
        private bool remember;
        public aunt()
        {
            InitializeComponent();
            
            remember = false;
        }



        private void CreateAcc_L_Click(object sender, EventArgs e)
        {
            singIn s = new singIn();
            s.ShowDialog();

        }
        private void showPass_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_cb.Checked)
            {
                password_tb.UseSystemPasswordChar = false;
            }
            else
            {
                password_tb.UseSystemPasswordChar = true;
            }
        }
        private void Log_in_b_Click(object sender, EventArgs e)
        {
            bool found = false;
            int id = 0;
            int lvl = 0;
            badLogIn_l.Visible = true;
            foreach(Person tempPerson in Persons)
            {
                if(username_tb.Text.Equals(tempPerson.getUsername()) && password_tb.Text.Equals(tempPerson.getPassword()))
                {
                    badLogIn_l.Visible = false;
                    found = true;
                    id = tempPerson.getId();
                    lvl = tempPerson.getLevel();
                }
            }
            if (found)
            {
                if(lvl < 2)
                {
                    student st = new student(id);
                    st.ShowDialog();
                }
                else
                {
                    employer em = new employer(id);
                    em.ShowDialog();
                }
            }

            

            
        }
        private void dontRemember_l_Click(object sender, EventArgs e)
        {
            if (dontRemember_l.Text.Equals("Отмена"))
            {
                dontRemember_l.Text = "Забыли пароль?";
                username_tb.Text = "";
                username_tb.Cue = "Username";
                password_tb.Text = "";
                password_tb.Cue = "Password";
                showPass_cb.Enabled = true;
                showPass_cb.Checked = false;
                remember = false;
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Помните ли вы ваш username?", "Уведомление", MessageBoxButtons.YesNoCancel);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    {
                        username_tb.Text = "";
                        username_tb.Cue = "Username";

                        break;
                    }
                case DialogResult.No:
                    {
                        username_tb.Text = "";
                        username_tb.Cue = "Номер телефона";
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }
            }
            dontRemember_l.Text = "Отмена";
            password_tb.Text = "";
            password_tb.Cue = "Кодовое слово";
            password_tb.UseSystemPasswordChar = false;
            showPass_cb.Enabled = false;
            remember = true;
        }



        #region Animation
        private void username_tb_TextChanged(object sender, EventArgs e)
        {
            badLogIn_l.Visible = false;
        }
        private void password_tb_TextChanged(object sender, EventArgs e)
        {
            badLogIn_l.Visible = false;
        }
        private void dontRemember_l_MouseEnter(object sender, EventArgs e)
        {
            dontRemember_l.ForeColor = Color.Orange;
        }
        private void dontRemember_l_MouseLeave(object sender, EventArgs e)
        {
            dontRemember_l.ForeColor = Color.Black;
        }
        private void Log_in_b_MouseEnter(object sender, EventArgs e)
        {
            Log_in_b.BackColor = Color.Magenta;
        }
        private void Log_in_b_MouseLeave(object sender, EventArgs e)
        {
            Log_in_b.BackColor = Color.DarkMagenta;
        }
        private void CreateAcc_L_MouseEnter(object sender, EventArgs e)
        {
            CreateAcc_L.ForeColor = Color.Orange;
        }
        private void CreateAcc_L_MouseLeave(object sender, EventArgs e)
        {
            CreateAcc_L.ForeColor = Color.Black;
        }
        #endregion

        

        private async void aunt_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ASUS-ZENBOOK;Initial Catalog=DBSchool;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [LogIn]", sqlConnection);

            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                Persons = new List<Person>();
                while(await sqlDataReader.ReadAsync())
                {
                    Person somePerson = new Person();
                    somePerson.setId(Convert.ToInt32(sqlDataReader["Id"]));
                    somePerson.setUsername(Convert.ToString(sqlDataReader["Username"]));
                    somePerson.setPassword(Convert.ToString(sqlDataReader["Password"]));
                    somePerson.setLevel(Convert.ToInt32(sqlDataReader["level"]));
                    Persons.Add(somePerson);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
            }

        }
    }
}
