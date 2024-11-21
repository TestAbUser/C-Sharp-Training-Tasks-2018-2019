using System.Collections.Generic;
using Task1.PointClasses;
using Task2;

namespace Task1.CircleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-15 11:45:03</DateOfCreation>
    /// <summary>
    /// Describes a circle.
    /// </summary>
    public class Circle : Round
    {
        private List<Point> points;
        private readonly Point center = new Point
        {
            X = 0,
            Y = 0
        };

        public List<Point> Points
        {
            get
            {
                points = new List<Point>()
                {
                    center
                };
                return points;
            }
        }
    }
}
