using System;
using System.Diagnostics.Contracts;
using Task1.PointClasses;
using Task2;

namespace Task1.RectangleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-27 15:24:15</DateOfCreation>
    /// <summary>
    /// Allows to change the parameters of a rectangle.
    /// </summary>
    public class RectangleDrawer : IFigureHandler
    {
        readonly Rectangle rectangle;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-09 17:36:34</DateOfCreation>    
        /// <summary>
        /// Creates an instance of rectangleHandler class that takes rectangle as a parameter.
        /// </summary>
        /// <param name="rectangle">Used for initialization.</param>
        public RectangleDrawer(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-09 18:32:38</DateOfCreation>
        /// <summary>
        /// Calculates the length of side A.
        /// </summary>
        /// <returns>Side A.</returns>
        public double CalculateSideA()
        {
            double sideA = Math.Abs(rectangle.Points[0].X - rectangle.Points[1].X);
            return sideA;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-09 18:33:07</DateOfCreation>
        /// <summary>
        /// Calculates the length of side B.
        /// </summary>
        /// <returns>Side B.</returns>
        public double CalculateSideB()
        {
            double sideB = Math.Abs(rectangle.Points[1].Y - rectangle.Points[2].Y);
            return sideB;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-17</DateOfCreation>
        /// <summary>
        /// Calculates the length of side C.
        /// </summary>
        /// <returns>Side C.</returns>
        public double CalculateSideC()
        {
            double sideC = Math.Abs(rectangle.Points[2].X - rectangle.Points[3].X);
            return sideC;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-17</DateOfCreation>
        /// <summary>
        /// Calculates the length of side D.
        /// </summary>
        /// <returns>Side D.</returns>
        public double CalculateSideD()
        {
            double sideD = Math.Abs(rectangle.Points[3].Y - rectangle.Points[0].Y);
            return sideD;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-09 18:33:26</DateOfCreation>
        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <returns>Area.</returns>
        public double CalculateArea()
        {
            double area = 0;
            if (VerifyCoordinates())
            {
                area = CalculateSideA() * CalculateSideB();
            }
            return area;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-09 18:34:00</DateOfCreation>
        /// <summary>
        /// Calculates the perimiter of a rectangle.
        /// </summary>
        /// <returns>Perimiter.</returns>
        public double CalculatePerimiter()
        {
            double perimiter = 0;

            if (VerifyCoordinates())
            {
                perimiter = CalculateSideA() * 2 + CalculateSideB() * 2;
            }
            return perimiter;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-10 17:39:17</DateOfCreation>
        /// <summary>
        /// Allows to change the coordinates of a rectangle.
        /// </summary>
        /// <param name="rectangle">Used for setting the new parameters of a rectangle.</param>
        /// <returns>Changed rectangle.</returns>
        public static Rectangle ChangeRectangle(Rectangle rectangle)
        {
            Contract.Requires(rectangle != null);
            Rectangle newRectangle = rectangle;
            Logger.ChangePointOption("A");
            newRectangle.Points[0] = PointDrawer.ChangePoint(newRectangle.Points[0]);
            Logger.ChangePointOption("B");
            newRectangle.Points[1] = PointDrawer.ChangePoint(newRectangle.Points[1]);
            Logger.ChangePointOption("C");
            newRectangle.Points[2] = PointDrawer.ChangePoint(newRectangle.Points[2]);
            Logger.ChangePointOption("D");
            newRectangle.Points[3] = PointDrawer.ChangePoint(newRectangle.Points[3]);
            return newRectangle;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-10 17:38:29</DateOfCreation>
        /// <summary>
        /// Checks that the entered coordinates are valid.
        /// </summary>
        /// <returns>True or false.</returns>
        public bool VerifyCoordinates()
        {
            bool areValid = false;
            if ((CalculateSideA() != 0) && (CalculateSideA() == CalculateSideC()))
            {
                if ((CalculateSideB() != 0) && (CalculateSideB() == CalculateSideD()))
                {
                    areValid = true;
                }
                else
                {
                    Logger.PrintIncorrectCoordinatesWarning();
                }
            }
            else
            {
                Logger.PrintIncorrectCoordinatesWarning();
            }
            return areValid;
        }
    }
}
