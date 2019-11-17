using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] MainArray = Create();
            Show(MainArray);
            Show(SortArr(MainArray));
        }
        //Сортировка
        
        //Тест ввода
        public static int Test(string str)
        {
            int i;
            for (; ; )
            {
                bool res = int.TryParse(str, out i);
                if ((res) & (i > 0) & (i < 10))
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз");
                    str = Console.ReadLine();
                }
            }
        }

        public static int[][]SortArr(int[][] array)
        {
            int n = 0;
            foreach (int[] subArr in array)
                n += subArr.Length;
            int[] temp = new int[n];            
            int a = 0;
            int b = 0;            
            foreach (int[] arr1 in array)
            {
                int i = 0;
                while (i<arr1.Length)
                {
                    temp[b] = array[a][i];
                    b++;
                    i++;
                }
                a++;
            }
            int z = 0;
            int temporary;
            while (z < temp.Length - 1)
            {
                if (temp[z] > temp[z + 1])
                {
                    temporary = temp[z];
                    temp[z] = temp[z + 1];
                    temp[z + 1] = temporary;
                    z = 0;
                    continue;
                }
                z++;
            }
            int d = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = temp[d];
                    d++;
                }
            }


            return array;
        }
            

        //Метод запроса пользователя о размерности и создание массива
        public static int[][] Create()
        {
            
            Console.WriteLine("Введите целое положительное количество подмассивов меньше 10 (просто чтоб не загружать консоль)");
            int a = Test(Console.ReadLine());
            int[][] arr = new int[a][];
            int b;
            for (b = 0; b < a; b++)
            {
                Console.Write($"Введите количество элемнтов для {b + 1} подмассива: ");
                int p = Test(Console.ReadLine());
                arr[b] = new int[p];
            }
            Random rnd = new Random();
            int x = 0;
            while (x < a)
            {
                int y = 0;
                while ( y < arr[x].Length)
                {
                    arr[x][y] = rnd.Next(0, 100);
                    y++;
                }
                x++;
            }
            return arr;
        }
        //вывеси массив в консоль в соответствием с требованием задания
        private static void Show(Array arr)
        {
            Console.Write("{");
            foreach (int[] a in arr)
            {
                Console.Write("{");
                foreach (int b in a)
                {
                    Console.Write(b.ToString() + ",");
                }
                Console.Write("},");
            }
            Console.WriteLine("}");
        }
    }
}
