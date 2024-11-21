using System;
using System.Diagnostics.Contracts;
using Task1.PointClasses;
using Task1.LineClasses;

namespace Task1.StraightLineClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-24 15:08:01</DateOfCreation>
    /// <summary>
    /// Allows to change the parameters of a straight line.
    /// </summary>
    public class StraightLineDrawer : ILineDrawer
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-20 18:23:14</DateOfCreation>
        /// <summary>
        /// Allows to change a straight line.
        /// </summary>
        public void ChangeLine()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-07 18:15:26</DateOfCreation>
        /// <summary>
        /// Allows to change the two points a line is drawn through.
        /// </summary>
        /// <param name="straightLine">Used for setting the new parameters of a straight line.</param>
        /// <returns>Changed straight line.</returns>
        public static StraightLine ChangeLine(StraightLine straightLine)
        {
            Contract.Requires(straightLine != null);
            StraightLine newStraightLine = straightLine;
            Logger.ChangePointOption("A");
            newStraightLine.Points[0] = PointDrawer.ChangePoint(newStraightLine.Points[0]);
            Logger.ChangePointOption("B");
            newStraightLine.Points[1] = PointDrawer.ChangePoint(newStraightLine.Points[1]);
            return newStraightLine;
        }
    }
}
