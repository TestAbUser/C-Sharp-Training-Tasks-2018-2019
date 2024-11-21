using System.Collections.Generic;
using Task1.PointClasses;

namespace Task1.RingClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-13 13:09:11</DateOfCreation>
    /// <summary>
    /// Describes a ring.
    /// </summary>
    public class Ring : Task02.Ring
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
