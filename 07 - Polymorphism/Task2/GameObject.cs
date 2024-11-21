using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 17:47:04</DateOfCreation>
    /// <summary>
    /// Describes any object of the game.
    /// </summary>
    public abstract class GameObject
    {
        public abstract List <Point> Ponts { get; set; }
    }
}
