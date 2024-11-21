namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 17:49:13</DateOfCreation>
    /// <summary>
    /// Describes a movable object.
    /// </summary>
    public abstract class MovableObject : GameObject
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 19:59:59</DateOfCreation>
        /// <summary>
        /// Allows to change the coordinates of an object.
        /// </summary>
        public abstract void Move();

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-19 20:00:16</DateOfCreation>
        /// <summary>
        /// Allows moving object to avoid obstacles.
        /// </summary>
        public abstract void AvoidObstacle();
    }
}
