using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class User
    {

        private string Login;
        private string FirstName;
        private string SecondName;
        private int Age;
        private string Date_of_completion;

        public string login
        {
            get
            {
                return Login;
            }

            set
            {
                this.Login = value;
            }

        }

        public string Firstname
        {
            get
            {
                return FirstName;
            }
            set
            {
                this.FirstName = value;
            }
        }

        public string Secondname
        {
            get
            {
                return SecondName;
            }

            set
            {
                this.SecondName = value;
            }
        }

        public int age
        {
            get
            {
                return Age;
            }

            set
            {
                this.Age = value;
            }
        }

        public string date_of_completion
        {
            get
            {
                return Date_of_completion;
            }

            set
            {
                this.Date_of_completion = value;
            }

        }

        public void worksheet()
        {
            Console.WriteLine("");

            Console.WriteLine("Create new worksheet");

            Console.WriteLine("Write your login");
            string login = Console.ReadLine();

            Console.WriteLine("Write your name");
            string Firstname = Console.ReadLine();

            Console.WriteLine("Write your secondname");
            string Secondname = Console.ReadLine();

            Console.Write("Write your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your date of completion");
            string date_of_completion = Console.ReadLine();

            Console.ReadKey();
            Console.WriteLine($"Your login {login} and name {Firstname} {Secondname}, your age is {age}. Today is {date_of_completion} ");
        }


    }
}
