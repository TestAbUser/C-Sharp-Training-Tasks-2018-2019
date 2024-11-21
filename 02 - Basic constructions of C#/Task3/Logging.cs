using System;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 21:18:55</DateOfCreation>
    /// <summary>
    /// Contains a method for displaying the sum in Console.
    /// </summary>
    public class Logging
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 21:19:17</DateOfCreation>
        /// <summary>
        /// Displays the sum in Console.
        /// </summary>
        /// <param name="sum">Sum of integer values.</param>
        public void PrintSumToConsole(int sum)
        {
            Console.WriteLine("The sum is = {0}", sum.ToString());
            Console.ReadLine();
        }
    }
}
