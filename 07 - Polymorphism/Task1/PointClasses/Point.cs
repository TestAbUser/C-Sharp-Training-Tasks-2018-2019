namespace Task1.PointClasses
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-26 12:28:27</DateOfCreation>
    /// <summary>
    /// Describes a point.
    /// </summary>
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-08-13 13:20:09</DateOfCreation>
        /// <summary>
        /// Creates an instance of Point class with the default X and Y coordinates.
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }
    }
}
