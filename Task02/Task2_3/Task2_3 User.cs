using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1900,12,31);
            User user = new User("Иванов", "Иван", "Иванович", dateTime);
            Console.WriteLine("Фамилия - {0}" +
                "\nИмя - {1}" +
                "\nОтчество - {2}" +
                "\nВозраст - {3}", user.LastName,user.FirstName,user.MiddleName,user.Age);
            
        }
        public class User
        {
            protected string lastName;
            protected string firstName;
            protected string middleName;
            protected DateTime birthDate;
            public string LastName { get => lastName; set => lastName = value; }
            public string FirstName { get => firstName; set => firstName = value; }
            public string MiddleName { get => middleName; set => middleName = value; }
            public DateTime BirthDate { get => birthDate; set => birthDate = value; }
            public double Age
            {
                get
                {
                    return DateTime.Now.Year - birthDate.Year;
                }
            }
            public User(string lastName, string firstName, string middleName, DateTime birthDate)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.middleName = middleName;
                this.birthDate = birthDate;
            }

            
        }
    }
}
