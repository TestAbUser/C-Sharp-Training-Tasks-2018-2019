using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.BonusClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:32:52</DateOfCreation>
    /// <summary>
    /// Describes an apple.
    /// </summary>
    public class Apple : Bonus
    {
        public override List<Point> Ponts { get; set; }
        public override string Colour { get; set; }
        public override string Shape { get; set; }
        public override string HealingEffect { get; set; }
    }
}
