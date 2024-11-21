using System;

namespace Task1
{
    /// <summary>
    /// Contains methods performing different operations with the array.
    /// </summary>
    public class ArrayHandler
    {
        const int ArrayLength = 10;
        readonly int[] RandomNumberBoundaries = {-100, 100 };
        Random randomNumber = new Random();

        /// <summary>
        /// Initializes the array with data.
        /// </summary>
        /// <returns>Integer array.</returns>
        public int[] FillArray()
        {
            int[] array = new int[ArrayLength];
            for (var i = 0; i < ArrayLength; i++)
            {
                array[i] = randomNumber.Next(RandomNumberBoundaries[0], RandomNumberBoundaries[1]);
            }
            return array;
        }

        /// <summary>
        /// Sorts the array elements in ascending order.
        /// </summary>
        /// <param name="unsortedArray">Unsorted integer array.</param>
        /// <returns>Sorted integer array.</returns>
        public int[] SortArrayAscending(int[] unsortedArray)
        {
            var sortedArray = unsortedArray;
            for (var i = 0; i < sortedArray.Length; i++)
            {
                for (var j = 0; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] < sortedArray[j])
                    {
                        int container = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = container;
                    }
                }
            }
            return sortedArray;
        }

        /// <summary>
        /// Finds the biggest value in the array.
        /// </summary>
        /// <param name="array">Integer array.</param>
        /// <returns>Maximal number.</returns>
        public int FindMax(int[] array)
        {
            array = SortArrayAscending(array);
            var max = array[array.Length - 1];
            return max;
        }

        /// <summary>
        /// Finds the smallest value in the array.
        /// </summary>
        /// <param name="array">Integer array.</param>
        /// <returns>The smallest value.</returns>
        public int FindMin(int[] array)
        {
            array = SortArrayAscending(array);
            var min = array[0];
            return min;
        }
    }
}
