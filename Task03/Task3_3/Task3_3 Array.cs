using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> input = "a b c d e f".Split(' ');           
            DynamicArray<string> test = new DynamicArray<string>();
            Console.WriteLine("Конструктор по умолчанию");            
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            Console.WriteLine("Конструктор принимающий массив");
            test = new DynamicArray<string>(input);
            Console.WriteLine(string.Join(", ",test));
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            Console.WriteLine("Действие Add");
            for (int i = 0; i <9; i++)
            {
                test.Add($"g{i}");
            }
            Console.WriteLine(string.Join(", ", test));
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            Console.WriteLine("Действие AddRange");
            test.AddRange(test);
            Console.WriteLine(string.Join(", ", test));
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            Console.WriteLine("Действие Insert");
            test.Insert(15, "inserted");
            Console.WriteLine(string.Join(", ", test));
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            Console.WriteLine("Действие Remove");
            test.Remove("f");
            Console.WriteLine(string.Join(", ", test));
            Console.WriteLine($"Кол-во элементов {test.Length}, емкость {test.Capacity}\n");

            CycledArray<string> cycled = new CycledArray<string>(test);
            Console.WriteLine(cycled[-15]);

            cycled.CapacityReduced = 5;
            foreach (var item in cycled)
            {                
                Console.Write(item);
            }
            //Console.WriteLine(string.Join(", ", cycled));
            Console.WriteLine($"Кол-во элементов {cycled.Length}, емкость {cycled.Capacity}\n");

            string[] array = cycled.ToArray();
            Console.WriteLine(string.Join(", ", array));

            

        }
    }
    
}
