using System;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:09:09</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:09:09</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            var consoleLine = "";
            Logger logger = new Logger();
            DataFormatter dataFormatter = new DataFormatter();
            logger.PrintMenu();
            while (consoleLine != "Esc")
            {
                consoleLine = Console.ReadLine();
                switch (consoleLine)
                {
                    case "Esc":
                        break;
                    default:
                        var splitLine = consoleLine.ToUpper().Split();
                        logger.PrintHeader();
                        string[] comparedCultures = dataFormatter.GetFormattedValues(splitLine);
                        logger.PrintFormattedValues(comparedCultures);
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
