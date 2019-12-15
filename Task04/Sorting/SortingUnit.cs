using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingUnit
    {
        public event Action OnSort;
        public void CustomSort<T>(T[] mas, Func<T, T, bool> ComparerDelegate)
        {
            T temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (ComparerDelegate(mas[i], mas[j]))
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            OnSort.Invoke();
            Show(mas);
        }
        public void ThreadSort<T>(T[]mas, Func<T, T, bool> ComparerDelegate)
        {
            new Thread(() =>
            {
                CustomSort(mas, ComparerDelegate);                
            }
             ).Start();            
        }
        private void Show<T> (T[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine(item);
                Thread.Sleep(100);
            }
        }
    }
    class SortingObserver
    {
        public void SortingComplete()
        {
            Console.WriteLine("Сортировка завершена");
        }

    }
}
