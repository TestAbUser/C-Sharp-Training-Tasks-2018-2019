using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-23 19:18:34</DateOfCreation>
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T> where T : new()
    {
        private T[] tArray;
        private int length;
        private int capacity;
        public DynamicArray() => tArray = new T[8];

        public DynamicArray(int size) => tArray = new T[size];

        public DynamicArray(T[] arrT) => this.tArray = arrT;

        public int Length
        {
            get
            {
                length = 0;
                foreach (var element in tArray)
                {
                    if (!Equals(element, default(T)))
                    {
                        length += 1;
                    }
                }
                return length;
            }
        }

        public int Capacity
        {
            get
            {
                capacity = 0;
                foreach (var element in tArray)
                {
                    capacity += 1;
                }
                return capacity;
            }
        }

        public T this[int i]
        {
            get => tArray[i];
            set => tArray[i] = value;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-23 14:49:49</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            Sort();
            if (Capacity == Length)
            {
                DoubleCapacity();
                tArray[Length / 2] = element;
            }
            else
            {
                tArray[Length] = element;
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-23 19:18:20</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void AddRange(T[] newArray)
        {
            Sort();
            int length = Length;
            T[] storageArray = tArray;
            tArray = new T[newArray.Length + length];
            for (int i = 0; i < length; i++)
            {
                tArray[i] = storageArray[i];
            }
            for (int i = length; i < Capacity; i++)
            {
                tArray[i] = newArray[i - length];
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-29 20:18:27</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            tArray[index] = default(T);
            return Equals(tArray[index], default(T));
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-30 01:10:27</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Insert(T element, int index)
        {
            bool isInserted;
            if (index < Capacity)
            {
                if (Length < Capacity)
                {
                    for (int i = Length; i == index; i--)
                    {
                        tArray[i + 1] = tArray[i];
                    }
                    tArray[index] = element;
                }
                else
                {
                    DoubleCapacity();
                }
                isInserted = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index cannot exceed Capacity");
            }
            return isInserted;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-30 01:10:55</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        public void DoubleCapacity()
        {
            var arr = tArray;
            tArray = new T[Capacity * 2];
            for (int i = 0; i < Capacity / 2; i++)
            {
                tArray[i] = arr[i];
            }

        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-29 21:09:02</DateOfCreation>
        /// <summary>
        /// 
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < Capacity; i++)
                for (int j = 0; j < Capacity - 1; j++)
                {
                    if (Equals(tArray[j], default(T)))
                    {
                        var storageArray = tArray[j];
                        tArray[j] = tArray[j + 1];
                        tArray[j + 1] = storageArray;
                    }
                }
        }
    }
}
