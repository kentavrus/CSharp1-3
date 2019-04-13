using System;
using System.Text.RegularExpressions;
using System.Windows;
using CSharp13.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAdult { get; }
        public string WesternSign { get; }
        public string ChineseSign { get; }
        public bool IsBirthday { get; }

        public int Age;

        public Person(string firstname, string lastname, string email, DateTime birth)
        {
            FirstName = firstname;
            LastName = lastname;
            if (!EmailValid(email)) throw new Email();
            Email = email;
            if (age(birth) > 135) throw new Old();
            if (age(birth) < 0) throw new Birth();
            DateOfBirth = birth;
            IsAdult = age(birth) > 18;
            WesternSign = westernZodiac();
            ChineseSign = chineseZodiac();
            IsBirthday = birthdayCheck();
        }

        private bool birthdayCheck()
        {
            DateTime now = DateTime.Today;
            DateTime birthday = DateOfBirth;
            return now.Day == birthday.Day && now.Month == birthday.Month;
        }

        private string westernZodiac()
        {
           int month = DateOfBirth.Month;
           int day = DateOfBirth.Day;

            string s = "";
            if (month == 1)
            {
                if (day <= 19)
                {
                    s = "Kozerog";
                }
                else
                {
                    s = "Vodoley";
                }
            }
            else if (month == 2)
            {
                if (day <= 18)
                {
                    s = "Vodoley";
                }
                else
                {
                    s = "Fish";
                }
            }
            else if (month == 3)
            {
                if (day <= 20)
                {
                    s = "Fish";
                }
                else
                {
                    s = "Oven";
                }
            }
            else if (month == 4)
            {
                if (day <= 19)
                {
                    s = "Oven";
                }
                else
                {
                    s = "Telets";
                }
            }
            else if (month == 5)
            {
                if (day <= 20)
                {
                    s = "Telets";
                }
                else
                {
                    s = "Twins";
                }
            }
            else if (month == 6)
            {
                if (day <= 20)
                {
                    s = "Twins";
                }
                else
                {
                    s = "Rak";
                }
            }
            else if (month == 7)
            {
                if (day <= 22)
                {
                    s = "Rak";
                }
                else
                {
                    s = "Lion";
                }
            }
            else if (month == 8)
            {
                if (day <= 22)
                {
                    s = "Lion";
                }
                else
                {
                    s = "Deva";
                }
            }
            else if (month == 9)
            {
                if (day <= 22)
                {
                    s = "Deva";
                }
                else
                {
                    s = "Vesi";
                }
            }
            else if (month == 10)
            {
                if (day <= 22)
                {
                    s = "Vesi";
                }
                else
                {
                    s = "Scorpion";
                }
            }
            else if (month == 11)
            {
                if (day <= 21)
                {
                    s = "Scorpion";
                }
                else
                {
                    s = "Strelets";
                }
            }
            else if (month == 12)
            {
                if (day <= 21)
                {
                    s = "Strelets";
                }
                else
                {
                    s = "Kozerog";
                }
            }



            return s;
        }
        private enum Zodiacs
        {
          Petuh, Pes, Borow, Patsuk, Bull, Tiger, Krol, Dragon, Zmia, Horse, Kozel, Monkey
        }

        private string chineseZodiac()
        {
            var year = DateOfBirth.Year;
            int i = year % 12;
            Console.Write(i + " ");
            var ii = (Zodiacs)i;
            return ii.ToString(); ;
        }
        private int age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int years = 0;
            if (now.Month < birthday.Month)
            {
                years = now.Year - birthday.Year - 1;
            }
            else if (now.Month > birthday.Month)
            {
                years = now.Year - birthday.Year;
            }
            else if (now.Month == birthday.Month)
            {
                if (now.Day < birthday.Day)
                {
                    years = now.Year - birthday.Year - 1;
                }
                else if (now.Day >= birthday.Day)
                {
                    years = now.Year - birthday.Year;
                }
            }
            Age = years;
            return years;
        }

        private bool EmailValid(string email)
        {
            Regex validEmailRegex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
+ "@"
+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", RegexOptions.IgnoreCase);
            return validEmailRegex.IsMatch(email);

        }
    }
}
