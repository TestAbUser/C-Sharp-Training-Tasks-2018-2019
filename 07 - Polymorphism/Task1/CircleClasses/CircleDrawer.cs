using System.Diagnostics.Contracts;
using Task1.PointClasses;
using Task2;

namespace Task1.CircleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-12 12:11:10</DateOfCreation>  
    /// <summary>
    /// Allows to change the parameters of a circle. 
    /// </summary>
    public class CircleDrawer : RoundHandler
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:16:11</DateOfCreation>
        /// <summary>
        /// Creates an instance of CircleHandler class that takes radius as a parameter.
        /// </summary>
        /// <param name="radius">Used for initialization.</param>
        public CircleDrawer(double radius) : base(radius)
        {

        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:13:36</DateOfCreation>
        /// <summary>
        /// Allows to change the center and the radius of a circle.
        /// </summary>
        /// <param name="circle">Used for setting the new parameters of a circle.</param>
        /// <returns>Changed circle.</returns>
        public static Circle ChangeCircle(Circle circle)
        {
            Contract.Requires(circle != null);
            Circle newCircle = circle;
            Logger.ChangePointOption("O");
            newCircle.Points[0] = PointDrawer.ChangePoint(newCircle.Points[0]);
            Task2.Logger.PrintRadiusOption();
            newCircle.R = RoundHandler.ChangeCoordinatesOrRadius(newCircle.R);
            return newCircle;
        }
    }
}
