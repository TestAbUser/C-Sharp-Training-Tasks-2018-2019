using System;

namespace Task2
{
    /// <summary>
    /// Contains the method for displaying array elements in Console.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Displays the array in Console.
        /// </summary>
        /// <param name="array">Three-dimensional integer array.</param>
        public virtual void PrintToConsole(int[,,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    for (var k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine("array [{0}{1}{2}]= {3}", i, j, k, array[i, j, k]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
