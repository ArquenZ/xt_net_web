using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SearchCalcuation
{
    class SearchCalculation
    {
        static void Main(string[] args)
        {
            int value = 555;
            int[] testarray = CreateIntArray(10000);
            testarray[1000] = value;
            testarray[5000] = value;
            testarray[9999] = value;
            Console.WriteLine("Время раБоты методов при нахождении искомого элемента в начале массива");            
            AllMeasurments(testarray, value, 30);
            testarray[1000] = 0;            
            Console.WriteLine("Время раБоты методов при нахождении искомого элемента в середине массива");
            AllMeasurments(testarray, value, 30);
            testarray[5000] = 0;            
            Console.WriteLine("Время раБоты методов при нахождении искомого элемента в конце массива");
            AllMeasurments(testarray, value, 30);
        }

        public static void AllMeasurments(int[] testarray, int value, int quantity)
        {   
            long case1 = TimeMeasure(quantity, () => FirstIndexOf(testarray, value));
            long case2 = TimeMeasure(quantity, () => FirstIndexOfPredicate(testarray, value, IsEqual));
            long case3 = TimeMeasure(quantity, () => FirstIndexOfPredicate(testarray, value, delegate (int a, int b)
            {
                return a == b;
            }));
            long case4 = TimeMeasure(quantity, () => FirstIndexOfPredicate(testarray, value, (x, y) => x == y));
            long case5 = TimeMeasure(quantity, () => testarray.Select((v, i) => new { value = v, index = i }).First(x => x.value == value));
            Console.WriteLine($"Время работы метода, непосредственно реализующего поиск = {case1}," +
                $"\nВремя работы метода, которому условие поиска передаётся через экземпляр делегата = {case2}," +
                $"\nВремя работы метода, которому условие поиска передаётся через делегат в виде анонимного метода = {case3}," +
                $"\nВремя работы метода, которому условие поиска передаётся через делегат в виде лямбда-выражения = {case4}," +
                $"\nВремя работы LINQ - выражения = {case5}" +
                $"\nКоличесвто измерений {quantity}" +
                $"\n_______________________________________");
        }        
        static bool IsEqual(int a,int b) 
        {
            return a == b;
        }        
        static int FirstIndexOf(int[] arr, int a)
        {
            int index = 0;
            foreach (var item in arr)
            {
                if (a == item)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        static int FirstIndexOfPredicate(int[] arr, int a, Func<int,int,bool> predicate)
        {
            int index = 0;
            foreach (var item in arr)
            {
                if (predicate(item, a))
                {
                    return index;
                }

                index++;
            }
            return -1;
        }
        public static int[] CreateIntArray(int length)
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
       
        public static long TimeMeasure (int quantity, Action action)
        {
            long[] c = new long[quantity];
            int i;
            for (i = 0; i < quantity; i++)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                action.Invoke();
                timer.Stop();
                c [i] = timer.ElapsedTicks;
                timer.Reset();                
            }
            c.OrderBy(x=>x);
            return c[i/2];
        }        
    }
}
