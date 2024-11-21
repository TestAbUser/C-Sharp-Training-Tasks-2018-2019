using System;
using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 17:50:42</DateOfCreation>
    /// <summary>
    /// Describes a player.
    /// </summary>
    public class Player : MovableObject
    {
        public override List <Point> Ponts { get; set; }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 17:51:20</DateOfCreation>
        /// <summary>
        /// Changes the player's coordinates.
        /// </summary>
        public override void Move()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 17:51:43</DateOfCreation>
        /// <summary>
        /// Allows the player to avoid obstacles.
        /// </summary>
        public override void AvoidObstacle()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 17:52:09</DateOfCreation>
        /// <summary>
        /// Allows the player to collect bonuses.
        /// </summary>
        public void PickUpBonus()
        {
            throw new NotImplementedException();
        }
    }
}
