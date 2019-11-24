using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr = Create(20);
            Show(arr);
            Show(SortArr(arr));
            Console.WriteLine("Минимальный элемент массива = " + MinArr(arr));
            Console.WriteLine("Максимальный элемент массива = " + MaxArr(arr));
        }
        static int[] SortArr(int[] arr)
        {
            int i = 0;
            int temp;
            while (i < arr.Length - 1)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i = 0;
                    continue;
                }
                i++;
            }
            return (arr);
        }
        public static int[] Create(int y)
        {
            Random rnd = new Random();
            int[] arr = new int[y];
            int i = 0;
            while (i < arr.Length)
            {
                arr[i] = rnd.Next(0, 100);
                i++;
            }
            return arr;
        }
        public static int MaxArr(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }
        public static int MinArr(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }
        public static void Show(int[] arr)
        {
            Console.WriteLine("Ваш массив");
            foreach (int item in arr)
            {                
                Console.Write(" "+ item);                
            }
            Console.WriteLine();
        }
    }
}
