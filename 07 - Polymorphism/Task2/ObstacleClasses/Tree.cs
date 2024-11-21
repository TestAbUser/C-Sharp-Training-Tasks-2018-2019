using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.ObstacleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:58:51</DateOfCreation>
    /// <summary>
    /// Describes a tree.
    /// </summary>
    public class Tree : Obstacle
    {
        public override List<Point> Ponts { get; set; }
        public override bool Impenetrable { get; }
    }
}
