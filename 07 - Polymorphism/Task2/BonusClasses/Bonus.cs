namespace Task2.BonusClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-08-19 19:34:54</DateOfCreation>
    /// <summary>
    /// Describes a bonus.
    /// </summary>
    public abstract class Bonus : GameObject
    {
        public abstract string Colour { get; set; }
        public abstract string Shape { get; set; }
        public abstract string HealingEffect { get; set; }
    }
}
