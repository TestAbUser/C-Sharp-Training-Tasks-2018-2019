using System;

namespace Task3
{
    /// <summary>
    /// Contains the method for displaying the sum in Console.
    /// </summary>
    public class Logger : Task1.Logger
    {
        /// <summary>
        /// Displays the sum in Console.
        /// </summary>
        /// <param name="sum">Sum of elements.</param>
        public void PrintSumToConsole(int sum)
        {
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();
        }
    }
}
