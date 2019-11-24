using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное значение стороны А");
            int a = InputTest(ReadInput());
            Console.WriteLine("Введите целое положительное значение стороны B");
            int b = InputTest(ReadInput());
            Console.WriteLine("Площадь прямоугольника = " + Square(a, b));
            //Console.WriteLine(InputTest(ReadInput()));
        }
        /// <summary>
        /// Метод ввода значения с консоли, парсит инт.
        /// </summary>
        /// <returns>целое значение</returns>
        private static int ReadInput()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректный ввод");
            }
            return a;
        }
        /// <summary>
        /// Проверка соответствия ввода условиям задания
        /// </summary>
        /// <param name="a">Целое значение</param>
        /// <returns>Значение соответствующее условиям задачи</returns>
        private static int InputTest(int a)
        {
            if (a > 0) return a;
            else
            {
                Console.WriteLine("Некорректный ввод");
                return ReadInput();
            }
        }
        //Во избежания переполнения при умножении двух интов привел к ulong
        private static ulong Square(int a, int b)
        {
            return ((ulong)a * (ulong)b);
        }

    }
}