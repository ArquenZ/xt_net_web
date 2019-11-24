using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_5
{
    class Task1_5
    {
        static void Main(string[] args)
        {
            SumOfNumbers();
            Console.ReadLine();
        }
        private static void SumOfNumbers()
        {
            int summ = 0;
            int i = 3;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
                i++;
            }
            Console.WriteLine($"Сумма чисел кратныx 3 или 5 составляет {summ}");
        }
    }
}
