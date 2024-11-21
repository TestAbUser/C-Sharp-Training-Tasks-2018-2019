using System;
using System.Diagnostics.Contracts;
using Task1.PointClasses;
using Task1.LineClasses;
using Task2;

namespace Task1.PeripheryClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-23 23:55:17</DateOfCreation>
    /// <summary>
    /// Allows to change the parameters of a periphery. 
    /// </summary>
    public class PeripheryDrawer : ILineDrawer
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-20 18:25:51</DateOfCreation>
        /// <summary>
        /// Allows to change a periphery.
        /// </summary>
        public void ChangeLine()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:19:31</DateOfCreation>
        /// <summary>
        /// Allows to change the center and the radius of a periphery.
        /// </summary>
        /// <param name="periphery">Used for setting the new parameters of a periphery.</param>
        /// <returns>Changed periphery.</returns>
        public static Periphery ChangeLine(Periphery periphery)
        {
            Contract.Requires(periphery != null);
            Periphery newPeriphery = periphery;
            Logger.ChangePointOption("O");
            newPeriphery.Points[0] = PointDrawer.ChangePoint(newPeriphery.Points[0]);
            Task2.Logger.PrintRadiusOption();
            newPeriphery.R = RoundHandler.ChangeCoordinatesOrRadius(newPeriphery.R);
            return newPeriphery;
        }
    }
}
