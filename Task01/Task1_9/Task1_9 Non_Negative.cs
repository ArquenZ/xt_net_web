using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9
{
    class Program
    {
        //И вот тут я загуглил tuple, надо было сделать это раньше :3
        static void Main(string[] args)
        {
            var array = Create(15);
            foreach (int item in array.arr)
            {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine("Сумма неотрицательных элементов массива = " + array.sum);            
        }        
        public static (int[]arr,int sum) Create(int y)
        {
            int sum = 0;
            Random rnd = new Random();
            int[] arr = new int[y];
            int i = 0;
            while (i < arr.Length)
            {
                arr[i] = rnd.Next(-100, 100);
                if (arr[i] > 0) sum += arr[i];
                i++;
            }
            return (arr,sum);
        }
    }
}
