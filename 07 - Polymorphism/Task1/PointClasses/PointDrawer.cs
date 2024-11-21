using System;
using System.Diagnostics.Contracts;
using Task2;

namespace Task1.PointClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-02 18:58:21</DateOfCreation>
    /// <summary>
    /// Allows to change the parameters of a point.
    /// </summary>
    public static class PointDrawer
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-02 18:59:26</DateOfCreation>
        /// <summary>
        /// Allows to change the X and Y coordinates of a point.
        /// </summary>
        /// <param name="point">Used for changing the parameters of a point.</param>
        /// <returns>Changed point.</returns>
        public static Point ChangePoint(Point point)
        {
            Contract.Requires(point != null);
            var newPoint = point;
            Task2.Logger.PrintCoordinateXOption();
            newPoint.X = ChangeCoordinate(newPoint.X);
            Task2.Logger.PrintCoordinateYOption();
            newPoint.Y = ChangeCoordinate(newPoint.Y);
            return newPoint;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-17</DateOfCreation>
        /// <summary>
        /// Allows to edit the coordinates of a point.
        /// </summary>
        /// <param name="coordinate">Used for setting a new coordinate.</param>
        /// <returns>New coordinate.</returns>
        public static double ChangeCoordinate(double coordinate)
        {
            var newCoordinate = coordinate;
            var coordinateValue = Console.ReadLine();
            newCoordinate = RoundHandler.ChangeParameter(coordinateValue, newCoordinate);
            return newCoordinate;
        }
    }
}
