
namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 13:49:12</DateOfCreation>
    /// <summary>
    /// Contains a method that calculates the area of a rectangle.
    /// </summary>
    public class AreaOfRectangle
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 13:49:12</DateOfCreation>
        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="sideA">Side A.</param>
        /// <param name="sideB">Side B.</param>
        /// <returns>Area of rectangle.</returns>
        public int CalculateArea(int sideA, int sideB)
        {
            int areaOfRectangle = sideA * sideB;
            return areaOfRectangle;
        }
    }          
}
