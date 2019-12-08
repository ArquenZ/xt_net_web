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
            IEnumerable<char> input = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };
            //ExpansionableArray<char> test2 = new ExpansionableArray<char>(input);
            ExpansionableArray<char> test = new ExpansionableArray<char>();
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);                
            //}
            //Console.WriteLine(test.Capacity);
            for (int i = 0; i < 13; i++)
            {
                test.Add('b');
            }
            int a = 0;
            //foreach (var item in test)
            //{
            //    Console.Write( a++ + " ");
            //    Console.WriteLine(item);
            //}
            test.AddRange(input);
            test[12] = 'h';
            foreach (var item in test)
            {
                Console.Write(a++ + " ");
                Console.WriteLine(item);
            }
            Console.WriteLine($"Кол-во Элементов = {test.Length}, Емкость = {test.Capacity}");
            
        }
    }
    class ExpansionableArray<T> : IEnumerable, IEnumerable<T>
    {
        public T[] arr;
        //Свойство Length — получение количества элементов. Не путать с ёмкостью (Capacity)
        public int Length { get ; private set ; } = 0;
        //Свойство Capacity — получение ёмкости: длины внутреннего массива.
        public int Capacity { get ;private set ; }
        //Индексатор, позволяющий работать с элементом с указанным номером. 
        //При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException
        public T this[int ind]
        {
            get
            {
                if (ind >= Length || ind < 0) throw new Exception("Неверный индекс");
                return arr[ind];
            }
            set
            {
                if (ind >= Length || ind < 0) throw new Exception("Неверный индекс");
                arr[ind] = value;
            }
        }
        //Конструктор без параметров (создаётся массив ёмкостью 8 элементов)
        public ExpansionableArray()
        {
            arr = new T[8];
            Capacity = 8;
        }
        //Конструктор с одним целочисленным параметром (создаётся массив указанной ёмкости)
        public ExpansionableArray(int cap)
        {
            arr = new T[cap];
            Capacity = cap;
        }
        //Конструктор, который в качестве параметра принимает коллекцию, реализующую интерфейс IEnumerable<T>,
        //создаёт массив нужного размера и копирует в него все элементы из коллекции
        public ExpansionableArray(IEnumerable<T> collection)
        {
            
            Capacity = collection.Count() * 2;
            arr = new T[Capacity];            
            foreach (var item in collection)
            {
                arr[Length] = item;
                Length++;
            }
        }
        //Метод Add, добавляющий в конец массива один элемент.При нехватке места для 
        //добавления элемента, ёмкость массива должна удваиваться.
        public void Add(T added)
        {
            CapacityCheck(Length+1);
            arr[Length] = added;
            Length++;
        }
        //Метод AddRange, добавляющий в конец массива содержимое коллекции, реализующей интерфейс IEnumerable<T>.
        // Обратите внимание, метод должен корректно учитывать число элементов в коллекции с тем, чтобы при 
        //необходимости расширения массива делать это только один раз вне зависимости от числа элементов в добавляемой коллекции.
        public void AddRange(IEnumerable<T> added)
        {
            CapacityCheck(Length + added.Count());
            foreach (var item in added)
            {
                Add(item);
            }
        }
        //Метод Remove, удаляющий из коллекции указанный элемент.Метод должен возвращать true, если удаление прошло успешно
        //и false в противном случае.При удалении элементов реальная ёмкость массива не должна уменьшаться.
        public void Remove()
        {

        }
        //Метод Insert, позволяющий добавить элемент в произвольную позицию массива (обратите внимание, может 
        //потребоваться расширить массив). Метод должен возвращать true, если добавление прошло успешно и false
        //в противном случае. При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException
        public void Insert()
        {

        }
        //Методы, реализующие интерфейсы IEnumerable и IEnumerable<T>
        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)arr).GetEnumerator();
        }
        //Проверка на емкость и увеличение емкости при необходимости
        private void CapacityCheck(int newlength)
        {
            if (Capacity < newlength)
            {
                int index = 0;
                while (Capacity < newlength)
                {
                    Capacity *= 2;
                }
                T[] temp = new T[Capacity];
                foreach (var item in arr)
                {
                    temp[index] = item;
                    index++;
                    
                }
                arr = temp;                
            }
        }        
    }
}
