using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var (arr, sum) = Create2dArr(5,5);
            foreach (int item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("Сумма элементов массива с четным индексом = " + sum);
        }
        static (int[,]arr,int sum) Create2dArr(int a, int b)
        {
            int sum = 0;
            Random rnd = new Random();
            int[,] arr = new int[a, b];
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    arr[x, y] = rnd.Next(-100, 100);
                    if ((x + y) % 2 == 0) sum += arr[x, y];
                }
            }
            return (arr,sum);
        }
    }
}
