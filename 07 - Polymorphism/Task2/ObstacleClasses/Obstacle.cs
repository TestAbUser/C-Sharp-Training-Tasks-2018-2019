namespace Task2.ObstacleClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:45:42</DateOfCreation>
    /// <summary>
    /// Describes an obstacle.
    /// </summary>
    public abstract class Obstacle : GameObject
    {
        public abstract bool Impenetrable { get; }
    }
}
