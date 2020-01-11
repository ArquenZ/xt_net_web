using System;
using System.Text.RegularExpressions;

namespace Task7_5
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter text");
            var text = Console.ReadLine();            
            Regex timeRegex = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]");
            var count = timeRegex.Matches(text).Count;            
            Console.WriteLine($"There is {count} time(s) in this text");
            Console.ReadLine();
        }
    }
}
