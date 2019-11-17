using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            String str = Console.ReadLine();
            Console.WriteLine(Simple(Test(str))? ("Число является простым") : ("Число не является простым"));
        }
        //Проверка правильности ввода возврат числа из строки
        public static int Test(string str)
        {
            int i;
            for (; ; )
            {
                bool res = int.TryParse(str, out i);
                if (res & i > 0)
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
        //Проверка является число простым
        public static bool Simple(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
