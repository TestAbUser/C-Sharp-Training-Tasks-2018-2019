using System;


namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:22:50</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:22:50</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            Triangle triangle = new Triangle();
            Logger.CreateTriangle(triangle);
            do
            {
                Logger.PrintSideAOption();
                triangle.SideA = TriangleHandler.ChangeSide(triangle.SideA);
                Logger.PrintSideBOption();
                triangle.SideB = TriangleHandler.ChangeSide(triangle.SideB);
                Logger.PrintSideCOption();
                triangle.SideC = TriangleHandler.ChangeSide(triangle.SideC);
                Logger.CreateTriangle(triangle);
                Logger.PrintMenu();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
