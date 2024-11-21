using System.Collections.Generic;
using Task1.PointClasses;
using Task1.LineClasses;

namespace Task1.StraightLineClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-26 13:17:51</DateOfCreation>
    /// <summary>
    /// Describes a straight line.
    /// </summary>
    public class StraightLine : ILine
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

        public List<Point> Points
        {
            get
            {
                points = new List<Point>()
                {
                    a, b
                };
                return points;
            }
        }
    }
}
