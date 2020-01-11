using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex normalRegex = new Regex(@"^[-]?\d+[,.]?\d*$");
            Regex scientificRegex = new Regex(@"^([-]?\d+[,.]?\d*)(([?*]10[-]?\d+)|([eE][-]?\d+))$");
            Console.WriteLine($"Enter number");
            string number = Console.ReadLine();
            if (normalRegex.IsMatch(number))
            {
                Console.WriteLine($"Normal notation {number}");
            }
            else if (scientificRegex.IsMatch(number))
            {
                Console.WriteLine($"Scientific notation {number}");
            }
            else
            {
                Console.WriteLine($"{number} is not a number!");
            }

        }

        private static void DetermineNumbersNotation()
        {
            

            
        }
    }
}
