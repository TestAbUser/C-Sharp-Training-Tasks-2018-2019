using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.BonusClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:35:28</DateOfCreation>
    /// <summary>
    /// Describes a cherry.
    /// </summary>
    public class Cherry : Bonus
    {
        public override List<Point> Ponts { get; set; }
        public override string Colour { get; set; }
        public override string Shape { get; set; }
        public override string HealingEffect { get; set; }
    }
}
