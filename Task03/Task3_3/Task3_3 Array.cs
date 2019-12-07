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
        }
    }
    class ExpansionableArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] arr;
        //Свойство Length — получение количества элементов. Не путать с ёмкостью (Capacity)
        public int Length { get; set; }
        //Свойство Capacity — получение ёмкости: длины внутреннего массива.
        public int Capacity { get; set; }
        //Индексатор, позволяющий работать с элементом с указанным номером. 
        //При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException
        public T this[int ind]
        {
            get
            {
                return arr[ind];
            }
            set
            {
                arr[ind] = value;
            }
        }
        //Конструктор без параметров (создаётся массив ёмкостью 8 элементов)
        public ExpansionableArray()
        {
            arr = new T[8];
        }
        //Конструктор с одним целочисленным параметром (создаётся массив указанной ёмкости)
        public ExpansionableArray(int cap)
        {
            arr = new T[cap];
        }
        //Конструктор, который в качестве параметра принимает коллекцию, реализующую интерфейс IEnumerable<T>,
        //создаёт массив нужного размера и копирует в него все элементы из коллекции
        public ExpansionableArray(IEnumerable<T> collection)
        {
            int length = collection.Count();
            arr = new T[length*2];            
        }
        //Метод Add, добавляющий в конец массива один элемент.При нехватке места для 
        //добавления элемента, ёмкость массива должна удваиваться.
        public void Add()
        {
            
        }
        //Метод AddRange, добавляющий в конец массива содержимое коллекции, реализующей интерфейс IEnumerable<T>.
        // Обратите внимание, метод должен корректно учитывать число элементов в коллекции с тем, чтобы при 
        //необходимости расширения массива делать это только один раз вне зависимости от числа элементов в добавляемой коллекции.
        public void AddRange()
        {

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
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        

    }
}
