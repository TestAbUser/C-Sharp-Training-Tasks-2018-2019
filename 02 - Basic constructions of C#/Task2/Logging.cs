using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 21:53:30</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying Menu and a triangle in Console.
    /// </summary>
    public class Logging
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 21:54:02</DateOfCreation>
        /// <summary>
        /// Displays Menu in Console.
        /// </summary>
        public void PrintMenuToConsole()
        {
            Console.WriteLine("Enter an integer number." +
                              "\nTo exit enter 'Esc'.");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-01 14:02:37</DateOfCreation>
        /// <summary>
        /// Displays a triangle in Console.
        /// </summary>
        /// <param name="numberOfRows">Defines the number of rows.</param>
        public void PrintTriangleToConsole(string[] numberOfRows)
        {
            for (var i = 0; i < numberOfRows.Length; i++)
            {
                Console.WriteLine(numberOfRows[i]);
            }
            Console.WriteLine();
        }
    }
}
