using System;
using Task1.CircleClasses;
using Task1.PeripheryClasses;
using Task1.RectangleClasses;
using Task1.RingClasses;
using Task1.StraightLineClasses;
using Task1.LineClasses;
using Task2;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-19 20:38:14</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public static class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-19 20:38:31</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        public static void Main()
        {
            StraightLine straightLine = new StraightLine();
            Periphery periphery = new Periphery();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Ring ring = new Ring();
            ILine[] lines = new ILine[] { straightLine, periphery };
            IFigure[] figures = new IFigure[] { rectangle, circle, ring };
            Logger.PrintMainMenu();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        lines[0] = StraightLineDrawer.ChangeLine((StraightLine)lines[0]);
                        Logger.PrintStraightLine((StraightLine)lines[0]);
                        break;
                    case ConsoleKey.D2:
                        lines[1] = PeripheryDrawer.ChangeLine((Periphery)lines[1]);
                        Logger.PrintPeriphery((Periphery)lines[1]);
                        break;
                    case ConsoleKey.D3:
                        figures[0] = RectangleDrawer.ChangeRectangle((Rectangle)figures[0]);
                        Logger.PrintRectangle((Rectangle)figures[0]);
                        break;
                    case ConsoleKey.D4:
                        figures[1] = CircleDrawer.ChangeCircle((Circle)figures[1]);
                        Logger.PrintCircle((Circle)figures[1]);
                        break;
                    case ConsoleKey.D5:
                        figures[2] = RingDrawer.ChangeRing((Ring)figures[2]);
                        Logger.PrintRing((Ring)figures[2]);
                        break;
                    case ConsoleKey.D6:
                        Logger.DisplayLines(lines);
                        Logger.DisplayFigures(figures);
                        break;
                    default:
                        break;
                }
                Logger.PrintMainMenu();
            } while (key != ConsoleKey.Escape);
        }
    }
}
