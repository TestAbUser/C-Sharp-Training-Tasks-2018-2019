using System.Linq;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-12 12:37:29</DateOfCreation>
    /// <summary>
    /// Contains a method for calculating the average length of a word.
    /// </summary>
    public class AverageLengthCalculator
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-12 12:38:12</DateOfCreation>
        /// <summary>
        /// Calculates the average length of a word.
        /// </summary>
        /// <param name="line">String line.</param>
        /// <returns>The average length of a word.</returns>
        public double FindAverageLength(string line)
        {
            string[] splitLine = line.Split();
            var averageLength = splitLine.Average((word) => word.Count((character) => !char.IsWhiteSpace(character)));
            return averageLength;
        }
    }
}
