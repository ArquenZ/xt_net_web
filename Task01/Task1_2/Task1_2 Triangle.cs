using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            Triangle(InputTest(ReadInput()));
            Console.ReadLine();
        }
        private static int ReadInput()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректный ввод");
            }
            return a;
        }
        private static int InputTest(int a)
        {
            if (a > 0) return a;
            else
            {
                Console.WriteLine("Некорректный ввод");
                return ReadInput();
            }
        }
        private static void Triangle(int a)
        {
            string s ="";
            for (int i = 0; i < a; i++)                
            {
                s = s + "*";                
                Console.WriteLine(s);

            }
        }
    }
}
