using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSchool
{
    class Person
    {
        private int id;
        private int level;
        private string lastName;
        private string name;
        private string patronymic;
        private string sex;
        private string birthday;
        private string number;
        private string email;
        private string position;
        private string secretWord;
        private string username;
        private string password;
        
        public Person()
        {
            id = 0;
            level = 0;
            lastName = "";
            name = "";
            patronymic = "";
            sex = "";
            birthday = "";
            number = "";
            email = "";
            position = "";
            secretWord = "";
            username = "";
            password = "";
        }
        #region Seters
        public void setId(int id)
        {
            this.id = id;
        }
        public void setLevel(int level)
        {
            this.level = level;
        }
        public void setlastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public void setBithday(string birthday)
        {
            this.birthday = birthday;
        }
        public void setNumber(string number)
        {
            this.number = number;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPosition(string position)
        {
            this.position = position;
        }
        public void setSecretWord(string secretWord)
        {
            this.secretWord = secretWord;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        #endregion

        #region getters
        public int getId()
        {
            return id;
        }
        public int getLevel()
        {
            return level;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getName()
        {
            return name;
        }
        public string getPatronymic()
        {
            return patronymic;
        }
        public string getSex()
        {
            return sex;
        }
        public string getBithday()
        {
            return birthday;
        }
        public string getNumber()
        {
            return number;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPosition()
        {
            return position;
        }
        public string getSecretWord()
        {
            return secretWord;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        #endregion
    }
}
