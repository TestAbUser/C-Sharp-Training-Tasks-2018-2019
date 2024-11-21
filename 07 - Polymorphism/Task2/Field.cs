using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 17:46:14</DateOfCreation>
    /// <summary>
    /// Describes a field.
    /// </summary>
    public class Field : GameObject
    {
        public override List<Point> Ponts { get; set; }
    }
}
