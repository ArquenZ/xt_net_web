using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для которой будут произведены удвоения символов");
            string InitialString = Console.ReadLine();
            Console.WriteLine("Введите строку, символы из которой будут уддваиваться в первой строке");
            string ContainerString = Console.ReadLine();
            var (DoubledString, Chars) = CharDoubler(InitialString, ContainerString);
            Console.WriteLine("Вот удвоенная строка \n" + DoubledString);
            Console.WriteLine("А вот символы, которые мы удвоили");
            foreach (char item in Chars) Console.WriteLine(item);          
            
        }
        static (string DoubledString, List<char> Chars) CharDoubler(string InitialString, string ContainerString)
        {
            List<char> chars = new List<char>();
            foreach (char item in ContainerString)
            {
                if (!chars.Contains(item) && !char.IsSeparator(item) && !char.IsPunctuation(item)) chars.Add(item);
            }
            foreach (char item in chars)
            {
                InitialString = InitialString.Replace(item.ToString(), item.ToString() + item.ToString());
            }
            return (InitialString, chars);

        }
    }
}
