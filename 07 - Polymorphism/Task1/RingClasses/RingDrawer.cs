using Task2;
using Task1.PointClasses;
using System.Diagnostics.Contracts;

namespace Task1.RingClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-13 13:24:42</DateOfCreation>
    /// <summary>
    /// Allows to change the parameters of a ring.
    /// </summary>
    public class RingDrawer : Task02.RingHandler
    {
        public RingDrawer(double r, double outerR) : base(r, outerR)
        {

        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:25:25</DateOfCreation>
        /// <summary>
        /// Allows to change the center, the inner and the outer radiuses of a ring.
        /// </summary>
        /// <param name="ring">Used for setting the new parameters of a ring.</param>
        /// <returns>Changed ring.</returns>
        public static Ring ChangeRing(Ring ring)
        {
            Contract.Requires(ring != null);
            Ring newRing = ring;
            Logger.ChangePointOption("O");
            newRing.Points[0] = PointDrawer.ChangePoint(newRing.Points[0]);
            Task2.Logger.PrintRadiusOption();
            newRing.R = RoundHandler.ChangeCoordinatesOrRadius(newRing.R);
            Logger.PrintOuterRadiusOption();
            newRing.OuterR = RoundHandler.ChangeCoordinatesOrRadius(newRing.OuterR);
            return newRing;
        }
    }
}
