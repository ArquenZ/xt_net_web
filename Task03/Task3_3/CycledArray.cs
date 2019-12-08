using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class CycledArray<T> : DynamicArray<T>, ICloneable, IEnumerator, IEnumerator<T>
    {
        public CycledArray() : base()
        {
        }
        public CycledArray(int cap) : base(cap)
        {
        }
        public CycledArray(IEnumerable<T> collection) : base(collection)
        {
        }
        public override T this[int ind]
        {
            get
            {
                if (ind >= Length || ind < -Length) throw new Exception("Неверный индекс");
                if (ind >= 0)
                    return arr[ind];
                else
                    return arr[Length + ind];
            }
            set
            {
                if (ind >= Length || ind < -Length) throw new Exception("Неверный индекс");
                if (ind >= 0)
                    arr[ind] = value;
                else
                    arr[Length + ind] = value;
            }
        }
        public override int Capacity { get; protected set; }
        public int CapacityReduced 
        {            
            set
            {
                SetCapacity(value);
            }
        }

        object ICloneable.Clone()
        {
            return new CycledArray<T>(arr);
        }

        private void SetCapacity(int cap)            
        {
            Capacity = cap;
            Length = cap;
            T[] temp = new T[cap];
            for (int i = 0; i < cap; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }
        public T[] ToArray()
        {
            T[] array = new T[Length];
            int index = 0;
            foreach (var item in arr)
            {
                array[index] = arr[index];
                index++;
            }
            return array;
        }
        public override bool MoveNext()
        {
            if (position < Length - 1)
            {
                position++;
                return true;
            }
            else
            { 
                Reset();            
                return true;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                if (position < 0||position >=Length) position = 0;
                return arr[position];
            }
        }
        T IEnumerator<T>.Current
        {
            get
            {
                if (position < 0 || position >= Length) position = 0;
                return arr[position];
            }
        }
    }
}
