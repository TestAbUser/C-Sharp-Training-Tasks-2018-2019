using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.ObstacleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:50:31</DateOfCreation>
    /// <summary>
    /// Describes a stone.
    /// </summary>
    public class Stone : Obstacle
    {
        public override List<Point> Ponts { get; set; }
        public override bool Impenetrable { get; }
    }
}
