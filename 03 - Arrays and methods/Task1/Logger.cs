using System;

namespace Task1
{
    /// <summary>
    /// Contains methods for displaying different menu options and warnings in Console.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Displays sorted array elements.
        /// </summary>
        /// <param name="array">Integer array.</param>
        public virtual void PrintArrayToConsole(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array [{0}]= {1}", i, array[i]);
            }
        }

        /// <summary>
        /// Displays the maximal value.
        /// </summary>
        /// <param name="max">Maximal number.</param>
        public void PrintMaxToConsole(int max)
        {
            Console.WriteLine("Max= {0}", max);
        }

        /// <summary>
        /// Displays the minimal value.
        /// </summary>
        /// <param name="min">Minimal number.</param>
        public void PrintMinToConsole(int min)
        {
            Console.WriteLine("Min= {0}", min);
            Console.ReadLine();
        }
    }
}
