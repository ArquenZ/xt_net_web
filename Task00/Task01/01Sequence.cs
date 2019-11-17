using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            String str = Console.ReadLine();
            Console.WriteLine(Line(Test(str)));
            Console.ReadLine();
        }
        //Проверка правильности ввода и возврат числа из строки
        public static int Test(string str)
        {
            int i;
            for (; ;)
            {   
                bool res = int.TryParse(str, out i);
                if (res& i>0)
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

        // Метод вывода последовательности
        public static string Line(int number)
        {
            string str = "";
            for (int i = 1; i <= number; i++)
            {
                str += i.ToString();
                if (i < number)
                    str += ",";
            }
            return str;
        }
    }
}
