namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 21:12:52</DateOfCreation>
    /// <summary>
    /// Contains metod calculating a sum.
    /// </summary>
    public class CalculationOfSum
    {
        private const int FirstDivisor = 3;
        private const int SecondDivisor = 5;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-12 12:07:10</DateOfCreation>
        /// <summary>
        /// Calculates the sum of all integer numbers less than 1000 that can be divided by 3 or 5 without a remainder.
        /// </summary>
        /// <param name="MaximalNumber">Upper limit.</param>
        /// <returns>The sum.</returns>
        public int CalculateSum(int MaximalNumber)
        {
            int sum = 0;
            for (var i = 0; i < MaximalNumber; i++)
            {
                if (i % FirstDivisor == 0 || i % SecondDivisor == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
