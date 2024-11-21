namespace Task4
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 21:47:09</DateOfCreation>
    /// <summary>
    /// Contains a method for creating an isosceles triangle.
    /// </summary>
    public class IsoscelesTriangleCreator
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 21:47:27</DateOfCreation>
        /// <summary>
        /// Create an isosceles triangle.
        /// </summary>
        /// <param name="numberOfRows">Number of rows in triangle.</param>
        /// <returns>Array of "*" characters.</returns>
        public string[] CreateIsoscelesTriangle(int numberOfRows)
        {
            var numberOfElementsInRow = numberOfRows * 2 + 1;
            string[] rowsOfTriangle = new string[numberOfRows];

            for (var i = 0; i < numberOfRows; i++)
            {
                string rowElements = "";
                for (var j = 1; j < numberOfElementsInRow; j++)
                {
                    if (j >= numberOfRows - i & j <= numberOfRows + i)
                    {
                        rowElements = rowElements + "*";
                    }
                    else
                    {
                        rowElements = rowElements + " ";
                    }
                }
                rowsOfTriangle[i] = rowElements;
            }
            return rowsOfTriangle;
        }
    }
}
