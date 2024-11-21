using System;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:21:12</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different menu options and warnings in Console.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 01:29:25</DateOfCreation>
        /// <summary>
        /// Displays Menu.
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("To continue, press any key." +
                              "\nTo exit, press 'ESC'.");
            Console.WriteLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 01:28:12</DateOfCreation>
        /// <summary>
        /// Displays the parameters of Triangle.
        /// </summary>
        /// <param name="triangle">Instance of Triangle.</param>
        public static void CreateTriangle(Triangle triangle)
        {
            if (triangle == null)
            {
                throw new ArgumentNullException(nameof(triangle));
            }
            if (TriangleHandler.CheckThatSidesAreCorrect(triangle.SideA, triangle.SideB, triangle.SideC))
            {
                Console.WriteLine();
                Console.WriteLine("Triangle has been created:" +
                    $"\nSide A = {triangle.SideA}" +
                    $"\nSide B = {triangle.SideB}" +
                    $"\nSide C = {triangle.SideC}" +
                    $"\nP = {triangle.Perimiter}" +
                    $"\nS = {triangle.Area}");
                Console.WriteLine();
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 00:51:42</DateOfCreation>
        /// <summary>
        /// Displays the option for changing side A.
        /// </summary>
        public static void PrintSideAOption()
        {
            Console.WriteLine("Enter a value for side A:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 00:51:42</DateOfCreation>
        /// <summary>
        /// Displays the option for changing side B.
        /// </summary>
        public static void PrintSideBOption()
        {
            Console.WriteLine("Enter a value for side B:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 00:52:39</DateOfCreation>
        /// <summary>
        /// Displays the option for changing side C.
        /// </summary>
        public static void PrintSideCOption()
        {
            Console.WriteLine("Enter a value for side C:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:21:54</DateOfCreation>
        /// <summary>
        /// Warns that the side must be positive.
        /// </summary>
        public static void PrintNegativeSideWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Side must be more than '0'!");
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 01:48:59</DateOfCreation>
        /// <summary>
        /// Warns that the value must be a positive double number.
        /// </summary>
        public static void PrintValueCriteriaWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The value must be a positive double number.");
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:22:09</DateOfCreation>
        /// <summary>
        /// Warns that the sum of two sides is smaller than the third one.
        /// </summary>
        public static void PrintIncorrectSidesWarning()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("A triangle cannot be created. Sum of any two sides should be bigger than the third side!");
            Console.ResetColor();
        }
    }
}
