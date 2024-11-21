using System;
using Task2;

namespace Task02
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 13:47:13</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public static class Program 
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-31 16:56:41</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
       public static void Main()
        {
            Ring ring = new Ring();
            Logger.DisplayRingProperties(ring);
            do
            {
                Task2.Logger.PrintCoordinateXOption();
                ring.X = RoundHandler.ChangeCoordinatesOrRadius(ring.X);
                Task2.Logger.PrintCoordinateYOption();
                ring.Y = RoundHandler.ChangeCoordinatesOrRadius(ring.Y);
                Task2.Logger.PrintRadiusOption();
                ring.R = RoundHandler.ChangeCoordinatesOrRadius(ring.R);
                Logger.PrintOuterRadiusOption();
                ring.OuterR = RoundHandler.ChangeCoordinatesOrRadius(ring.OuterR);
                Logger.DisplayRingProperties(ring);
                Task2.Logger.PrintMenu();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
