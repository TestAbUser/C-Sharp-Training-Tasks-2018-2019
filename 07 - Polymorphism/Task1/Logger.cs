using System;
using System.Diagnostics.Contracts;
using Task1.Properties;
using Task1.CircleClasses;
using Task1.PeripheryClasses;
using Task1.RectangleClasses;
using Task1.StraightLineClasses;
using Task1.RingClasses;
using Task1.LineClasses;
using Task2;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-19 20:19:50</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different Menu options and warnings.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-19 20:19:50</DateOfCreation>
        /// <summary>
        /// Displays the main menu.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Resources.MainMenu);
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-17</DateOfCreation>
        /// <summary>
        /// Displays the option for changing the point.
        /// </summary>
        /// <param name="point">Used for displaying the name of a point.</param>
        public static void ChangePointOption(string point)
        {
            Console.WriteLine($"Change point {point}:");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-01 12:38:22</DateOfCreation>
        /// <summary>
        /// Displays a straight line.
        /// </summary>
        /// <param name="straightLine">Used for displaying the parameters of a straight line.</param>
        public static void PrintStraightLine(StraightLine straightLine)
        {
            Contract.Requires(straightLine != null);
            Console.WriteLine(Resources.StraightLine, straightLine.Points[0].X,
                              straightLine.Points[0].Y, straightLine.Points[1].X, straightLine.Points[1].Y);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-01 12:38:52</DateOfCreation>
        /// <summary>
        /// Displays a periphery.
        /// </summary>
        /// <param name="periphery">Used for displaying the parameters of a periphery.</param>
        public static void PrintPeriphery(Periphery periphery)
        {
            Contract.Requires(periphery != null);
            Console.WriteLine(Resources.Periphery, periphery.Points[0].X,
                              periphery.Points[0].Y, periphery.R, periphery.Circumference);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:06:51</DateOfCreation>
        /// <summary>
        /// Displays a circle.
        /// </summary>
        /// <param name="circle">Used for displaying the parameters of a circle.</param>
        public static void PrintCircle(Circle circle)
        {
            Contract.Requires(circle != null);
            Console.WriteLine(Resources.Circle, circle.Points[0].X,
                              circle.Points[0].Y, circle.R, circle.Perimiter, circle.Area);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-01 15:29:03</DateOfCreation>
        /// <summary>
        /// Displays a rectangle.
        /// </summary>
        /// <param name="rectangle">Used for displaying the parameters of a rectangle.</param>
        public static void PrintRectangle(Rectangle rectangle)
        {
            Contract.Requires(rectangle != null);
            RectangleDrawer rectangleHandler = new RectangleDrawer(rectangle);
            if (rectangleHandler.VerifyCoordinates())
            {
                Console.WriteLine(Resources.Rectangle, rectangle.Points[0].X, rectangle.Points[0].Y, rectangle.Points[1].X,
                                      rectangle.Points[1].Y, rectangle.Points[2].X, rectangle.Points[2].Y,
                                      rectangle.Points[3].X, rectangle.Points[3].Y, rectangle.Area,
                                      rectangle.Perimiter);
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-10</DateOfCreation>
        /// <summary>
        /// Displays the option for changing the outer radius.
        /// </summary>
        public static void PrintOuterRadiusOption()
        {
            Console.WriteLine(Resources.OuterRadiusOption);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:04:14</DateOfCreation>
        /// <summary>
        /// Displays a ring.
        /// </summary>
        /// <param name="ring">Used for displaying the parameters of a ring.</param>
        public static void PrintRing(Ring ring)
        {
            Contract.Requires(ring != null);
            Console.WriteLine(Resources.Ring, ring.Points[0].X, ring.Points[0].Y, ring.R, ring.OuterR,
                              ring.Perimiter, ring.OuterPerimiter, ring.Area, ring.OuterCircleArea);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:05:01</DateOfCreation>
        /// <summary>
        /// Displays the warning if the coordinates are invalid.
        /// </summary>
        public static void PrintIncorrectCoordinatesWarning()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Resources.IncorrectCoordinatesWarning);
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-15</DateOfCreation>
        /// <summary>
        /// Displays the lines.
        /// </summary>
        /// <param name="lines">Used for displaying the parameters of lines.</param>
        public static void DisplayLines(ILine[] lines)
        {
            Contract.Requires(lines != null);
            PrintStraightLine((StraightLine)lines[0]);
            PrintPeriphery((Periphery)lines[1]);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-15</DateOfCreation>
        /// <summary>
        /// Displays the figures.
        /// </summary>
        /// <param name="figures">Used for displaying the parameters of figures.</param>
        public static void DisplayFigures(IFigure[] figures)
        {
            Contract.Requires(figures != null);
            PrintRectangle((Rectangle)figures[0]);
            PrintCircle((Circle)figures[1]);
            PrintRing((Ring)figures[2]);
        }
    }
}
