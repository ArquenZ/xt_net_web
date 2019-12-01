using System;
using static Task2_3.Program;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthTime = new DateTime(1980, 12, 31);
            DateTime startTime = new DateTime(2001, 12, 31);               
            Employee user = new Employee("Иванов", "Иван", "Иванович", birthTime,"Начальник отела",startTime);
            Console.WriteLine("Фамилия - {0}" +
                "\nИмя - {1}" +
                "\nОтчество - {2}" +
                "\nВозраст - {3}" +
                "\nДолжность - {4}" +
                "\nСтаж - {5} лет", user.LastName, user.FirstName, user.MiddleName, user.Age, user.Position, user.Stage);            
        }        
            public class Employee : User
            {
                string position;
                DateTime startingDate;
                public string Position { get => position; set => position = value; }
                public DateTime StartingDate { get => startingDate; set => startingDate = value; }
                public double Stage
                {
                    get
                    {
                        return DateTime.Now.Year - startingDate.Year;
                    }
                }
                public Employee(string lastName, string firstName, string middleName, DateTime birthDate, string position,
                    DateTime startingDate) : base(lastName, firstName, middleName, birthDate)
                {
                    this.position = position;
                    this.startingDate = startingDate;
                }
            }
        
    }
}
