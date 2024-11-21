using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:36:47</DateOfCreation>
    /// <summary>
    /// Contains methods that display the menu and the results of the calculation in Console.
    /// </summary>
    public class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:36:47</DateOfCreation>
        /// <summary>
        /// Asks to enter the first line in Console.
        /// </summary>
        public void PrintMenu()
        {
            Console.WriteLine("To exit, type 'Esc' and press 'Enter'." +
                              "\nEnter a line:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:36:47</DateOfCreation>
        /// <summary>
        /// Prints the average length of a word to Console.
        /// </summary>
        /// <param name="averageLength">Average length of a word.</param>
        public void PrintAverageLength(double averageLength)
        {
            Console.WriteLine("Average length of a word is = {0}", averageLength);
            Console.WriteLine();
        }
    }
}
