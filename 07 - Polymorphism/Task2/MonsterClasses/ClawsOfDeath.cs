using System;
using System.Collections.Generic;
using Task1.PointClasses;

namespace Task2.MonsterClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:38:18</DateOfCreation>
    /// <summary>
    /// Describes a claws of death.
    /// </summary>
    public class ClawsOfDeath : Monster
    {
        public override List<Point> Ponts { get; set; }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 19:55:40</DateOfCreation>
        /// <summary>
        /// Allows to change the coordinates.
        /// </summary>
        public override void Move()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 19:55:58</DateOfCreation>
        /// <summary>
        /// Allows to chase the player, if he is in the line of sight.
        /// </summary>
        public override void AttackPlayer()
        {
            throw new NotImplementedException();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 19:56:01</DateOfCreation>
        /// <summary>
        /// Allows to avoid obstacles.
        /// </summary>
        public override void AvoidObstacle()
        {
            throw new NotImplementedException();
        }
    }
}
