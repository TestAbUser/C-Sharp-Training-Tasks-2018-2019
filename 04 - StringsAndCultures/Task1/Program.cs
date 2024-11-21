using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:02:33</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:02:33</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            var consoleLine = "";
            Logger logger = new Logger();
            AverageLengthCalculator averageLengthCalculator = new AverageLengthCalculator();
            LineHandler lineHandler = new LineHandler();
            logger.PrintMenu();
            while (consoleLine != "Esc")
            {
                consoleLine = Console.ReadLine();
                switch (consoleLine)
                {
                    case "Esc":
                        break;
                    default:
                        consoleLine = lineHandler.RemovePunctuation(consoleLine);
                        double averageLength = averageLengthCalculator.FindAverageLength(consoleLine);
                        logger.PrintAverageLength(averageLength);
                        break;
                }
            }
        }
    }
}
