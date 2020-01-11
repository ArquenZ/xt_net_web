using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_3
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter text to search for e-mail adresses");
            string text = Console.ReadLine();
            Regex mailRegex = new Regex(@"\b([a-zA-Z0-9][a-zA-Z0-9.\-_]*[a-zA-Z0-9])@([a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9].){1,}[a-zA-Z]{2,6}\b");
            var matches = mailRegex.Matches(text);
            if (matches.Count > 0)
            {
                Console.WriteLine("Those correct e-mail addresses were found:");
                foreach (var item in matches)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No correct e-mail addresses were found");
            }
            Console.ReadLine();
        }
    }
}
