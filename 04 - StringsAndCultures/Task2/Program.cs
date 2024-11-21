using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:07:42</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:08:26</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            var firstLine = "";
            Logger logger = new Logger();
            LinesHandler linesHandler = new LinesHandler();
            logger.EnterFirstLineMessage();
            while (firstLine != "Esc")
            {
                firstLine = Console.ReadLine();
                switch (firstLine)
                {
                    case "Esc":
                        break;
                    default:
                        logger.EnterSecondLineMessage();
                        var secondLine = linesHandler.CheckForEsc(Console.ReadLine());
                        var resultingLine = linesHandler.DoubleLineCharacters(firstLine, secondLine);
                        logger.PrintResultingLine(resultingLine);
                        break;
                }
                logger.EnterFirstLineMessage();
            }
        }
    }
}
