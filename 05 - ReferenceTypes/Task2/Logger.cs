using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:15:18</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different menu options and warnings in Console.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-13 11:26:33</DateOfCreation>
        /// <summary>
        /// Displays the parameters of Round.
        /// </summary>
        /// <param name="round">Instance of a Round.</param>
        public static void PrintRound(Round round)
        {
            if (round == null)
            {
                throw new ArgumentNullException(nameof(round));
            }
            Console.WriteLine($"\nRound has been created. The parameters for Round are: (x = {round.X}, y = {round.Y}, r = {round.R})" +
                              $"\nThe circumference is = {round.Perimiter}" +
                              $"\nThe area is = { round.Area}");
            Console.WriteLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:15:18</DateOfCreation>
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
        /// <DateOfCreation>2019-05-10 19:34:32</DateOfCreation>
        /// <summary>
        /// Displays the option for changing 'x' coordinate.
        /// </summary>
        public static void PrintCoordinateXOption()
        {
            Console.WriteLine("Enter a value for 'x' coordinate:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-10 19:34:55</DateOfCreation>
        /// <summary>
        /// Displays the option for changing 'y' coordinate.
        /// </summary>
        public static void PrintCoordinateYOption()
        {
            Console.WriteLine("Enter a value for 'y' coordinate:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-10 19:35:20</DateOfCreation>
        /// <summary>
        /// Displays the option for changing radius.
        /// </summary>
        public static void PrintRadiusOption()
        {
            Console.WriteLine("Enter a value for radius:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:16:24</DateOfCreation>
        /// <summary>
        /// Warns that the radius cannot be negative.
        /// </summary>
        public static void PrintNegativeRadiusWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Radius can't be negative or null.");
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:16:35</DateOfCreation>
        /// <summary>
        /// Warns that the entered value has an invalid type.
        /// </summary>
        public static void PrintInvalidDataWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Incorrect data entered.");
            Console.ResetColor();
        }
    }
}
