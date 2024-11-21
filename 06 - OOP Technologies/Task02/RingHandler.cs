using System;
using Task2;

namespace Task02
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 12:08:09</DateOfCreation>
    /// <summary>
    /// Contains methods for calculating some parameters of the Ring object.
    /// </summary>
    public class RingHandler : RoundHandler
    {
        private  readonly double outerR;
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-29 12:10:09</DateOfCreation>
        /// <summary>
        /// Creates the RingHandler object, that takes the radius and outer radius as its parameters.
        /// </summary>
        /// <param name="r">Used to calculate some of the properties of a ring.</param>
        /// <param name="outerR">Used to calculate some of the properties of a ring.</param>
        public RingHandler(double r, double outerR) : base(r)
        {
            this.outerR = outerR;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-29 12:33:52</DateOfCreation>
        /// <summary>
        /// Sums the inner and outer circamferences.
        /// </summary>
        /// <returns>The Sum of the inner and outer circamferences.</returns>
        public double CalculateSumOfCircumferences()
        {
            var sum = CalculatePerimiter() + CalculateOuterCircumference();
            return sum;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 18:45:45</DateOfCreation>
        /// <summary>
        /// Calculates the circumference of the outer circle.
        /// </summary>
        /// <returns>The circumference of the outer circle.</returns>
        public double CalculateOuterCircumference()
        {
            return 2 * Math.PI * outerR;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 18:46:33</DateOfCreation>
        /// <summary>
        /// Calculates the area of the outer circle.
        /// </summary>
        /// <returns>The area of the outer circle.</returns>
        public double CalculateOuterArea()
        {
            return Math.PI * Math.Pow(outerR, 2);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-29 12:40:52</DateOfCreation>
        /// <summary>
        /// Calculates the area of the ring.
        /// </summary>
        /// <returns>The area of a ring.</returns>
        public double CalculateAreaOfRing()
        {
            var areaOfRing = CalculateOuterArea() - CalculateArea();
            return areaOfRing;
        }
    }
}
