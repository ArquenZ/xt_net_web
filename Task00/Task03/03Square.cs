using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное нечетное число больше 2");
            String str = Console.ReadLine();
            Square(Test(str));
            Console.ReadLine();
        }        
        private static void Square(int number)
        {
            int i = number / 2;
            for (int y = 0; y < number; y++)
            {
                if (y != 0) Console.WriteLine();
                for (int x = 0; x < number; x++)
                {
                    Console.Write((y != i || x != i) ? ("*"):(" "));
                }
            }
            Console.WriteLine();
        }
        public static int Test(string str)
        {
            int i;
            for (; ; )
            {
                bool res = int.TryParse(str, out i);
                if ((res) & (i > 2) & (i%2 !=0))
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз");
                    str = Console.ReadLine();
                }
            }
        }
    }
}
