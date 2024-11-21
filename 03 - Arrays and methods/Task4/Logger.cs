using System;
namespace Task4
{
    /// <summary>
    /// Contains the method for displaying array in Console.
    /// </summary>
    public class Logger : Task3.Logger
    {
        /// <summary>
        /// Displays array elements.
        /// </summary>
        /// <param name="array">Two-dimensional integer array.</param>
        public void PrintArrayToConsole(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("array [{0}{1}]= {2}", i, j, array[i, j]);
                }
            }
        }
    }
}
