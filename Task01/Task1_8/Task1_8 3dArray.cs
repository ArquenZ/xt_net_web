using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = Create3dArr(4, 3, 4);
            arr = ArrToZero(arr,4,3,4);            
        }

        static int[,,] Create3dArr(int a, int b, int c)
        {
            Random rnd = new Random();
            int[,,] array = new int[a, b, c];
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    for (int z = 0; z < c; z++)
                    {
                        array[x, y, z] = rnd.Next(-100, 100);
                    }
                }
            }
            return array;
        }
        static int[,,] ArrToZero(int[,,] array, int a, int b, int c)
        {
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    for (int z = 0; z < c; z++)
                    {
                        if (array[x, y, z] > 0)
                        {
                            array[x, y, z] = 0;
                        }
                        Console.Write(" " + array[x, y, z]);                            
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}
