using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter text to replace HTML tags");
            string text = Console.ReadLine();
            text = Regex.Replace(text, @"<[^>]*>", "_");
            Console.WriteLine("Replaced text: " + text);
            Console.ReadLine();
        }
    }
}
