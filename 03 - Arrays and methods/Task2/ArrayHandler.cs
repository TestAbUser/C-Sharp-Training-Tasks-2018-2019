using System;

namespace Task2
{
    /// <summary>
    /// Contains methods performing different operations with the array.
    /// </summary>
    public class ArrayHandler
    {
        readonly int[] ArrayDimensions = { 5, 5, 5 };
        readonly int[] RandomNumberBoundaries = {-100, 100};

        /// <summary>
        /// Initializes the array with data.
        /// </summary>
        /// <returns>Three-dimensional integer array.</returns>
        public int[,,] FillArray()
        {
            Random randomNumber = new Random();
            int[,,] array = new int[ArrayDimensions[0], ArrayDimensions[1], ArrayDimensions[2]];
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    for (var k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = randomNumber.Next(RandomNumberBoundaries[0], RandomNumberBoundaries[1]);
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Replaces all positive numbers in the array with zero and displays all the elements of the array.
        /// </summary>
        /// <param name="array">Three-dimensional integer array.</param>
        /// <returns>Three-dimensional integer array with zeros.</returns>
        public int [,,] ReplacePositiveWithZero(int [,,] array)
        {
            var zeroArray = array;
            for (var i = 0; i < zeroArray.GetLength(0); i++)
            {
                for (var j = 0; j < zeroArray.GetLength(1); j++)
                {
                    for (var k = 0; k < zeroArray.GetLength(2); k++)
                    {
                        if (zeroArray[i, j, k] > 0)
                        {
                            zeroArray[i, j, k] = 0;
                        }
                    }
                }
            }
            return zeroArray;
        }
    }
}
