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
            Console.WriteLine("Введите число треугольников");
            Tree(Triangle(InputTest(ReadInput())));

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
        private static string[] Triangle(int a)
        {
            string[] arr = new string[a];
            string s = "*";
            //создаем последнюю строку в массиве строк
            for (int i = 0; i < a - 1; i++)
            {
                s = s + "**";
            }
            //заполняем оостальной массив
            for (int i = a - 1; i >= 0; i--)
            {
                try
                {
                    arr[i] = s;
                    s = s.Substring(0, s.Length - 2);
                    s = " " + s;
                }
                catch
                {
                    arr[i] = s;
                }
            }            
            return arr;
        }
        private static void Tree(string[] arr)
        {
            int a = arr.Length;
            for (int x=arr.Length; x>=0; x--)
            {                
                for (int i = 0; i < a-x; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }            
        }
    }
}
