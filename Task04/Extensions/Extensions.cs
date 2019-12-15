using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.4. NUMBER ARRAY SUM
//Расширить массивы чисел методом, позволяющим найти их сумму.
//4.5. TO INT OR NOT TO INT?
//Расширить строку методом, определяющим, является ли она 
//положительным целым числом. Стандартные методы преобразования 
//строки в число (Parse и т.п.) не использовать.
namespace Extensions
{
    class Extensions
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2147483647 };
            Console.WriteLine(arr.Sum());
            string str = "745678934657893246837948";
            string str2 = "7456789346dsfsdgsddsd";
            Console.WriteLine(str.IsStringPositiveNumber());
            Console.WriteLine(str2.IsStringPositiveNumber());
        }
    }
    public static class ExtensionOfNumbers
    {
        public static long Sum(this int[] array)
        {
            long result = 0;
            foreach (var item in array)
            {
                result += item;                
            }
            return result;
        }       
    }
    public static class ExtensionOfStrings
    {
        public static bool IsStringPositiveNumber(this string s) => s.All(char.IsDigit);
    }
}
