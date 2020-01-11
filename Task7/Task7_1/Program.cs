using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text to search for date");
            string text = Console.ReadLine();
            Regex dateRegex = new Regex(@"\b(0?[1-9]|[1-2][0-9]|[3][0-1])-(0?[1-9]|[1][0-2])-[1-9]\d{3}\b");
            var date = dateRegex.Match(text);
            if (DateTime.TryParse(date.ToString(), out DateTime a))
            {
                Console.WriteLine("There is a correct date in a text");                
            }
            else
            {
                Console.WriteLine("There is no correct date in a text");
            }

            Console.ReadLine();
        }
    }
}
