using System.Collections.Generic;
using Task1.PointClasses;

namespace Task1.LineClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-13 19:41:08</DateOfCreation>
    /// <summary>
    /// Describes an abstract line.
    /// </summary>
    public interface ILine
    {
         List<Point>  Points { get; }
    }
}
