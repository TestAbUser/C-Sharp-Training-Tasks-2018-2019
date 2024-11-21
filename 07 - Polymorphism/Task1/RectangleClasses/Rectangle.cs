using System.Collections.Generic;
using Task1.PointClasses;
using Task2;

namespace Task1.RectangleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-13 19:42:04</DateOfCreation>
    /// <summary>
    /// Describes a rectangle.
    /// </summary>
    public class Rectangle : IFigure
    {
        private List<Point> points;

        private readonly Point a = new Point
        {
            X = 1,
            Y = 1
        };

        private readonly Point b = new Point
        {
            X = -1,
            Y = 1
        };

        private readonly Point c = new Point
        {
            X = -1,
            Y = -1
        };

        private readonly Point d = new Point
        {
            X = 1,
            Y = -1
        };

        public List<Point> Points
        {
            get
            {
                points = new List<Point>()
                {
                   a, b, c, d
                };

                return points;
            }
        }

        public double Perimiter
        {
            get
            {
                RectangleDrawer rectangleHandler = new RectangleDrawer(this);
                return rectangleHandler.CalculatePerimiter();
            }
        }

        public double Area
        {
            get
            {
                RectangleDrawer rectangleHandler = new RectangleDrawer(this);
                return rectangleHandler.CalculateArea();
            }
        }
    }
}
