namespace Task2.MonsterClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:39:00</DateOfCreation>
    /// <summary>
    /// Describes a monster.
    /// </summary>
    public abstract class Monster : MovableObject
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 19:58:02</DateOfCreation>
        /// <summary>
        /// Makes a monster chase the player, if he is in the line of sight.
        /// </summary>
        public abstract void AttackPlayer();
    }
}
