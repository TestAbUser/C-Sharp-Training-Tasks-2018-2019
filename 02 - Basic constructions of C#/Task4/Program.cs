using System;
using Task2;

namespace Task4
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 22:00:04</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 22:00:44</DateOfCreation>
        /// <summary>
        /// Displays the Menu in Console, calls the methods that validate data from Console and display 
        /// isosceles triangle in it. 
        /// </summary>
        static void Main()
        {
            var consoleLine = "";
            var logging = new Logging();
            var validationOfInput = new ValidationOfInput();
            var triangleCreator = new IsoscelesTriangleCreator();
            logging.PrintMenuToConsole();
            while (consoleLine != "Esc")
            {
                consoleLine = Console.ReadLine();
                switch (consoleLine)
                {
                    case "Esc":
                        break;
                    default:
                        var number = validationOfInput.ReturnValidatedNumber(consoleLine);
                        var triangle = triangleCreator.CreateIsoscelesTriangle(number);
                        logging.PrintTriangleToConsole(triangle);
                        logging.PrintMenuToConsole();
                        break;
                }
            }
        }
    }
}
