using System;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:20:00</DateOfCreation>
    /// <summary>
    /// Contains methods for calculating some parameters of the Round object.
    /// </summary>
    public class RoundHandler : IFigureHandler
    {

        private readonly double radius;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-13 11:38:01</DateOfCreation>
        /// <summary>
        /// Creates a RoundHandler object, that takes a value of 'double' type as a parameter.
        /// </summary>
        /// <param name="radius">Used for calculation of the other parameters.</param>
        public RoundHandler(double radius)
        {
            this.radius = radius;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:20:00</DateOfCreation>
        /// <summary>
        /// Calculates the circumference.
        /// </summary>
        /// <returns>The circumference.</returns>
        public double CalculatePerimiter()
        {
            return 2 * Math.PI * radius;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:20:00</DateOfCreation>
        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>The area.</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:20:00</DateOfCreation>
        /// <summary>
        /// Parses the line for new coordinate or radius.
        /// </summary>
        /// <param name="consoleLine">Used for parsing.</param>
        /// <param name="coordinateOrRadius">Pre-existing value.</param>
        /// <returns>Either the coordinate or radius.</returns>
        public static double ChangeParameter(string consoleLine, double coordinateOrRadius)
        {
            var newCoordinateOrRadius = coordinateOrRadius;
            var isDouble = double.TryParse(consoleLine, out double number);
            if (isDouble)
            {
                newCoordinateOrRadius = number;
            }
            else
            {
                Logger.PrintInvalidDataWarning();
            }
            return newCoordinateOrRadius;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-06 21:44:43</DateOfCreation>
        /// <summary>
        /// Allows to change the coordinates or radius.
        /// </summary>
        /// <param name="parameter">Current value.</param>
        /// <returns>New value.</returns>
        public static double ChangeCoordinatesOrRadius(double parameter)
        {
            var newParameter = parameter;
            var consoleLine = Console.ReadLine();
            newParameter = ChangeParameter(consoleLine, newParameter);
            return newParameter;
        }
    }
}