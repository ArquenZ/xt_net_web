using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class DynamicArray<T> : IEnumerable, IEnumerable<T>, IEnumerator, IEnumerator<T>
    {
        public T[] arr;       
        public int Length { get; protected set; } = 0;        
        public virtual int Capacity { get; protected set; }
        public virtual T this[int ind]
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
        protected int position = -1;
        public DynamicArray()
        {
            arr = new T[8];
            Capacity = 8;
        }
        public DynamicArray(int cap)
        {
            arr = new T[cap];
            Capacity = cap;
        }
        public DynamicArray(IEnumerable<T> collection)
        {

            Capacity = collection.Count() * 2;
            arr = new T[Capacity];
            foreach (var item in collection)
            {
                arr[Length] = item;
                Length++;
            }
        }
        public void Add(T added)
        {
            CapacityCheck(Length + 1);
            arr[Length] = added;
            Length++;
        }
        public void AddRange(IEnumerable<T> added)
        {
            int index = 0;            
            int count = added.Count();
            foreach (var item in added)
            {
                Add(item);
                index++;
                if (index > count - 1)
                {
                    Reset();
                    break;
                }                
            }
        }
        //Метод Remove, удаляющий из коллекции указанный элемент.Метод должен возвращать true, если удаление прошло успешно
        //и false в противном случае.При удалении элементов реальная ёмкость массива не должна уменьшаться.
        public bool Remove(T removed)
        {
            for (int i = 0; i < Length; i++)
            {
                if (arr[i].GetHashCode() == removed.GetHashCode())
                {
                    for (; i < Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    Length--;
                    return true;
                }
            }
            return false;
        }

        //Метод Insert, позволяющий добавить элемент в произвольную позицию массива (обратите внимание, может 
        //потребоваться расширить массив). Метод должен возвращать true, если добавление прошло успешно и false
        //в противном случае. При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException
        public void Insert(int place, T inserted)
        {
            if (place > Length || place < 0) throw new Exception("Неверный индекс");
            CapacityCheck(Length++);            
            T temp = arr[place];
            for (int i = Length; i > place; i--)
            {
                arr[i+1] = arr[i];
            }
            arr[place] = inserted;
            arr[place + 1] = temp;
        }
        public IEnumerator GetEnumerator()
        {
            return this; /*arr.GetEnumerator();*/
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this; /*((IEnumerable<T>)arr).GetEnumerator();*/
        }        
        T IEnumerator<T>.Current
        {
            get
            {
                //if (position == -1 || position >= Length)
                //    throw new InvalidOperationException();
                return arr[position];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return arr[position];
            }
        }
        public virtual bool MoveNext()
        {
            if (position < Length - 1)
            {
                position++;
                return true;
            }
            else
                Reset();
            return false;
        }
        public virtual void Reset()
        {
            position = -1;
        }
        void IDisposable.Dispose()
        {
        }
        //Проверка на емкость и увеличение емкости при необходимости
        protected void CapacityCheck(int newlength)
        {
            int capacity = Capacity;
            if (capacity < newlength)
            {                
                T[] temp = new T[capacity*2];
                for (int i = 0; i < Length; i++)
                {
                    temp[i] = arr[i];                    
                }
                arr = temp;
                Capacity = capacity * 2;
            }
        }
    }
}
