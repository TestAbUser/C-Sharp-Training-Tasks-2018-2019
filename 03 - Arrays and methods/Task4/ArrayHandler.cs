using System;

namespace Task4
{
    /// <summary>
    /// Contains methods performing different operations with the array.
    /// </summary>
    public class ArrayHandler
    {
        readonly int[] ArrayDimensions = { 3, 3, };
        const int RandomNumberBoundaries = 10;

        /// <summary>
        /// Initializes the array with data.
        /// </summary>
        /// <returns>Two-dimensional integer array.</returns>
        public int[,] FillArray()
        {
            int[,] array = new int[ArrayDimensions[0], ArrayDimensions[1]];
            Random randomNumber = new Random();
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = randomNumber.Next(RandomNumberBoundaries);
                }
            }
            return array;
        }

        /// <summary>
        /// Calculates the sum of all elements in the array located in even positions.
        /// </summary>
        /// <param name="array">Two-dimensional integer array.</param>
        /// <returns>Sum of elements.</returns>
        public int SumElementsInEvenPositions(int[,] array)
        {
            int sum = 0;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
