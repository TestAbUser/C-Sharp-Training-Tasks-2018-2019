using System;
using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.MonsterClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:36:02</DateOfCreation>
    /// <summary>
    /// Describes a bear.
    /// </summary>
    public class Bear : Monster
    {
        public override List<Point> Ponts { get; set; }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-21 13:22:45</DateOfCreation>
        /// <summary>
        /// Allows to change the coordinates.
        /// </summary>
        public override void Move()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-21 13:23:05</DateOfCreation>
        /// <summary>
        /// Allows to chase the player, if he is in the line of sight.
        /// </summary>
        public override void AttackPlayer()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-21 13:23:22</DateOfCreation>
        /// <summary>
        /// Allows to avoid obstacles.
        /// </summary>
        public override void AvoidObstacle()
        {
            throw new NotImplementedException();
        }
    }
}
