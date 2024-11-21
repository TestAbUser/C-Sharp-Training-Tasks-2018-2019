using System;
using Task2;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-03 01:19:57</DateOfCreation>
    /// <summary>
    /// Contains methods for calculating some parameters of a Triangle object.
    /// </summary>
    public class TriangleHandler : IFigureHandler
    {
        readonly Triangle triangle;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-13 11:40:27</DateOfCreation>
        /// <summary>
        /// Creates a TriangleHandler object, that takes a Triangle object as a parameter.
        /// </summary>
        /// <param name="triangle">Used for calculation of some parameters.</param>
        public TriangleHandler(Triangle triangle)
        {
            this.triangle = triangle;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:24:34</DateOfCreation>
        /// <summary>
        /// Calculates the perimiter of a triangle.
        /// </summary>
        /// <returns>The perimiter.</returns>
        public double CalculatePerimiter()
        {
            return triangle.SideA + triangle.SideB + triangle.SideC;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:24:51</DateOfCreation>
        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <returns>The area.</returns>
        public double CalculateArea()
        {
            var semiPerimiter = CalculatePerimiter() / 2;
            return Math.Sqrt(semiPerimiter * (semiPerimiter - triangle.SideA) *
                (semiPerimiter - triangle.SideB) * (semiPerimiter - triangle.SideC));
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-03 01:20:50</DateOfCreation>
        /// <summary>
        /// Parses line for new value of a side.
        /// </summary>
        /// <param name="consoleLine">Used for parsing.</param>
        /// <param name="triangleSide">Pre-existing value.</param>
        /// <returns>The length of a side.</returns>
        public static double ChangeSideLength(string consoleLine, double triangleSide)
        {
            var isDouble = double.TryParse(consoleLine, out double length);
            if (isDouble)
            {
                triangleSide = length;
            }
            else
            {
                Logger.PrintValueCriteriaWarning();
            }
            return triangleSide;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:24:51</DateOfCreation>
        /// <summary>
        /// Checks that the sum of any two sides is more than the third one.
        /// </summary>
        /// <param name="sideA">Used for validation.</param>
        /// <param name="sideB">Used for validation.</param>
        /// <param name="sideC">Used for validation.</param>
        /// <returns>A bool value.</returns>
        public static bool CheckThatSidesAreCorrect(double sideA, double sideB, double sideC)
        {
            var valuesAreValid = false;

            if ((sideA + sideC > sideB) & (sideA + sideB > sideC) & (sideB + sideC > sideA))
            {
                valuesAreValid = true;
            }
            else
            {
                Logger.PrintIncorrectSidesWarning();
            }
            return valuesAreValid;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-10 18:21:45</DateOfCreation>
        /// <summary>
        /// Replaces old value for a side with the new one.
        /// </summary>
        /// <param name="length">Current value.</param>
        /// <returns>New length of a side.</returns>
        public static double ChangeSide(double length)
        {
            var newLength = length;
            var consoleLine = Console.ReadLine();
            newLength = ChangeSideLength(consoleLine, newLength);
            return newLength;
        }
    }
}
