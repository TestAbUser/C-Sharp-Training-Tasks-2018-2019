using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:17:07</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:17:27</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            Round round = new Round();
            Logger.PrintRound(round);
            do
            {
                Logger.PrintCoordinateXOption();
                round.X = RoundHandler.ChangeCoordinatesOrRadius(round.X);
                Logger.PrintCoordinateYOption();
                round.Y = RoundHandler.ChangeCoordinatesOrRadius(round.Y);
                Logger.PrintRadiusOption();
                round.R = RoundHandler.ChangeCoordinatesOrRadius(round.R);
                Logger.PrintRound(round);
                Logger.PrintMenu();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
