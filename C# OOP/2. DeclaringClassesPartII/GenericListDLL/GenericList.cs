using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList.Common
{
    public class GenericList<T>
    {
        private T[] array;
        private int count = 0;
        private int size;

        public GenericList(int size)
        {
            this.size = size;
            this.array = new T[size];
        }

        public void Add(T element)
        {
            if (this.count >= this.array.Length)
            {
                EnsureCapacity();
            }

            this.array[count] = element;
            this.count++;
        }

        private void EnsureCapacity()
        {
            T[] newArray = new T[this.array.Length * 2];
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index > this.array.Length)
            {
                throw new ArgumentOutOfRangeException(index + (" is outside the boundaries of the array"));
            }
            else
            {
                if (this.count >= this.array.Length)
                {
                    EnsureCapacity();
                    count++;
                }

                T[] tempArray = new T[this.array.Length];
                for (int i = 0; i < index; i++)
                {
                    tempArray[i] = this.array[i];
                }
                tempArray[index] = element;
                for (int i = index + 1; i < this.array.Length; i++)
                {
                    tempArray[i] = this.array[i - 1];
                }
                this.array = tempArray;
            }
        }

        public void Clear()
        {
            this.array = new T[size];
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.array.Length)
            {
                throw new ArgumentOutOfRangeException(index + (" is outside the boundaries of the array"));
            }
            else
            {
                T[] tempArray = new T[this.array.Length];
                for (int i = 0; i < index; i++)
                {
                    tempArray[i] = this.array[i];
                }
                for (int i = index + 1; i < this.array.Length; i++)
                {
                    tempArray[i - 1] = this.array[i];
                }
                this.array = tempArray;
                count--;
            }
        }

        public T Max()
        {
            return (T)(object)this.array.Max();
        }

        public T Min()
        {
            return (T)(object)this.array.Min();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.array.Length; i++)
            {
                sb.Append(this.array[i]);
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public int Length
        {
            get { return this.array.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (index > count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.array[index];
            }
        }
    }
}
