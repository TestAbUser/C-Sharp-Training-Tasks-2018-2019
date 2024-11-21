using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 19:41:05</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 19:44:09</DateOfCreation>
        /// <summary>
        /// Displays the Menu in Console, calls the methods that validate data from Console and display 
        /// right triangle in it. 
        /// </summary>
        static void Main()
        {
            var consoleValue = "";
            var logging = new Logging();
            var validationOfInput = new ValidationOfInput();
            var rightTriangle = new RightTriangleCreator();
            logging.PrintMenuToConsole();
            while (consoleValue != "Esc")
            {
                consoleValue = Console.ReadLine();
                switch (consoleValue)
                {
                    case "Esc":
                        break;
                    default:
                        var number = validationOfInput.ReturnValidatedNumber(consoleValue);
                        var triangle = rightTriangle.CreateRightTriangle(number);
                        logging.PrintTriangleToConsole(triangle);
                        logging.PrintMenuToConsole();
                        break;
                }
            }
        }
    }
}

