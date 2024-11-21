namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 16:59:07</DateOfCreation>
    /// <summary>
    /// Contains a method for displaying a right triangle in Console.
    /// </summary>
    public class RightTriangleCreator
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 16:53:21</DateOfCreation>
        /// <summary>
        /// Displays a right triangle in Console.
        /// </summary>
        /// <param name="numberOfRows">The number of rows.</param>
        /// <returns>Array of "*" characters.</returns>
        public string[] CreateRightTriangle(int numberOfRows)
        {
            var rowsInTriangle = new string[numberOfRows];
            if (numberOfRows > 0)
            {
                rowsInTriangle[0] = "*";
                for (var i = 1; i < numberOfRows; i++)
                {
                    rowsInTriangle[i] = rowsInTriangle[i - 1] + "*";
                }
            }
            return rowsInTriangle;
        }
    }
}
