using System;
using Task02.Properties;

namespace Task02
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 11:47:46</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different Menu options and warnings in Console.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-31 16:46:18</DateOfCreation>
        /// <summary>
        /// Displays the properties of a ring.
        /// </summary>
        /// <param name="ring">Used for displaying the properties.</param>
        public static void DisplayRingProperties(Ring ring)
        {
            if (ring == null)
            {
                throw new ArgumentNullException(nameof(ring));
            }
            Console.WriteLine(Resources.RingParameters, ring.X, ring.Y, ring.R, ring.OuterR, ring.Perimiter,
                              ring.OuterPerimiter, ring.SumOfPerimiters, ring.Area,ring.OuterCircleArea, ring.RingArea);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-31 16:47:00</DateOfCreation>
        /// <summary>
        /// Displays the option for changing the outer radius.
        /// </summary>
        public static void PrintOuterRadiusOption()
        {
            Console.WriteLine(Resources.OuterRadiusOption);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 17:03:58</DateOfCreation>
        /// <summary>
        /// Warns that the value entered for the inner radius is bigger than the value for the outer radius.
        /// </summary>
        public static void PrintInnerRadiusTooBigWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Resources.InnerRadiusTooBigWarning);
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 17:04:14</DateOfCreation>
        /// <summary>
        /// Warns that the value entered for the outer radius is smaller than the value for the inner radius.
        /// </summary>
        public static void PrintOuterRadiusTooSmallWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Resources.OuterRadiusTooSmallWarning);
            Console.ResetColor();
        }
    }
}