using System.Text.RegularExpressions;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:17:29</DateOfCreation>
    /// <summary>
    /// Contains a method that removes unnecessary characters from the line.
    /// </summary>
    public class LineHandler
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:17:29</DateOfCreation>
        /// <summary>
        /// Removes all non-alphanumeric characters from the line.
        /// </summary>
        /// <param name="line">String line.</param>
        /// <returns>The line with alphanumeric characters.</returns>
        public string RemovePunctuation(string line)
        {
            //Removes all characters except alphanumeric ones, dash, apostrophe and white-space.
            var pattern = "[^a-zA-Z0-9']+";
            var replacement = " ";
            Regex rgx = new Regex(pattern);
            string resultingLine = rgx.Replace(line, replacement).Trim();
            return resultingLine;
        }
    }
}
