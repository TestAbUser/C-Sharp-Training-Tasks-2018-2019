using System.Collections.Generic;
using Task1.PointClasses;
using Task1.LineClasses;

namespace Task1.PeripheryClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-13 19:42:34</DateOfCreation>
    /// <summary>
    /// Describes a periphery.
    /// </summary>
    public class Periphery : ILine
    {
        private List<Point> points;
        private readonly Point center = new Point
        {
            X = 0,
            Y = 0
        };

        private double r;
        private double circumference;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-07-01 13:29:01</DateOfCreation>    
        /// <summary>
        /// Creates an instance of Periphery class with the default radius.
        /// </summary>
        public Periphery()
        {
            R = 1;
        }

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

        public double R
        {
            get
            {
                return r;
            }

            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    Task2.Logger.PrintNegativeRadiusWarning();
                }
            }
        }

        public double Circumference
        {
            get
            {
                Task2.RoundHandler roundHandler = new Task2.RoundHandler(R);
                circumference = roundHandler.CalculatePerimiter();
                return circumference;
            }
        }
    }
}
