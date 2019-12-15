using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            SortingUnit sortingUnit = new SortingUnit();
            SortingObserver sortingObserver = new SortingObserver();
            //SortingObserver sortingObserver2 = new SortingObserver();
            sortingUnit.OnSort += sortingObserver.SortingComplete;
            //sortingUnit.OnSort += sortingObserver2.SortingComplete;
            string[] arr1 = ("Написать метод, реализующий упорядочивание массива " +
                "произвольного типа. Принцип сравнения двух элементов должен передаваться" +
                " в метод через делегат. Стандартные инструменты типа Array.Sort и IComparable не " +
                "использовать.").Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            string[] arr2 = ("Продемонстрировать работу метода, упорядочив массив строк " +
                "по возрастанию длины. Строки равной длины между собой упорядочивать в алфавитном " +
                "порядке.").Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            sortingUnit.CustomSort(arr1, StringCompare);
            sortingUnit.ThreadSort(arr2, StringCompare); /*new thread*/
            foreach (var item in arr1) /*main thread*/
            {
                Console.WriteLine(item);
                Thread.Sleep(100);
            }

        }
        //Method comparing strings to input as a delegate into CustomSort parameter
        public static bool StringCompare(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return true;
            }
            else if (s1.Length < s2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] > s2[i])
                        return true;
                    if (s1[i] < s2[i])
                        return false;
                }
                return true;
            }
        }
    }
}
