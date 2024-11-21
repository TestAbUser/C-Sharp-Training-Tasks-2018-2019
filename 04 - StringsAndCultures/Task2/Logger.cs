using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:06:01</DateOfCreation>
    /// <summary>
    /// Contains methods that display the menu and the results in Console.
    /// </summary>
    public class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:06:48</DateOfCreation>
        /// <summary>
        /// Asks to enter the first line.
        /// </summary>
        public void EnterFirstLineMessage()
        {
            Console.WriteLine("To exit, type 'Esc' and press 'Enter'." +
                              "\nEnter the first line:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:07:17</DateOfCreation>
        /// <summary>
        /// Asks to enter the second line.
        /// </summary>
        public void EnterSecondLineMessage()
        {
            Console.WriteLine("Enter the second line:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:07:17</DateOfCreation>
        /// <summary>
        /// Displays the resulting line.
        /// </summary>
        /// <param name="line">Console line.</param>
        public void PrintResultingLine(string line)
        {
            Console.WriteLine("The resulting line is:" +
                              "\n" + line);
            Console.WriteLine();
        }
    }
}
