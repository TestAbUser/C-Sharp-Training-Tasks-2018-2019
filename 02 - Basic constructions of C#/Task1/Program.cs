using System;

namespace Task1
{

    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 15:41:42</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 15:43:35</DateOfCreation>
        /// <summary>
        /// Displays the menu in Console, calls the methods that validate data from Console and calculate the area 
        /// of the rectangle.
        /// </summary>
        static void Main()
        {
            var consoleLine = "";
            Console.WriteLine("Enter integer values for the sides A and B. Use space as a delimiter.");
            Console.WriteLine("To exit enter 'Esc'.");
            var validationOfInput = new ValidationOfInput();
            var area = new AreaOfRectangle();
            while (consoleLine != "Esc")
            {
                consoleLine = Console.ReadLine();
                switch (consoleLine)
                {
                    case "Esc":
                        break;
                    default:
                        var sides = validationOfInput.ReturnValidatedSides(consoleLine);
                        Console.WriteLine("Area of the rectangle is: " + area.CalculateArea(sides[0], sides[1]));
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
