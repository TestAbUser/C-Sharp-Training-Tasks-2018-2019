using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:04:19</DateOfCreation>   
    /// <summary>
    /// Contains a method that doubles necessary characters.
    /// </summary>
    public class LinesHandler
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-10-17 13:05:06</DateOfCreation>
        /// <summary>
        /// Removes all characters except capital letters from the line.
        /// </summary>
        /// <param name="line">String line.</param>
        /// <returns>Line with capital letters.</returns>
        public string RemoveAllButCapitals(string line)
        {
            //Removes all characters except capital letters.
            var pattern = "[^A-Z]";
            var replacement = "";
            Regex rgx = new Regex(pattern);
            string resultingLine = rgx.Replace(line, replacement).Trim();
            return resultingLine;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:05:16</DateOfCreation>
        /// <summary>
        /// Doubles in first line all characters that exist in second line.
        /// </summary>
        /// <param name="firstLine">First console line.</param>
        /// <param name="secondLine">Second console line.</param>
        /// <returns>Line with doubled characters.</returns>
        public string DoubleLineCharacters(string firstLine, string secondLine)
        {
            secondLine = new string(secondLine.ToLower().Distinct().ToArray());
            var secondLineCapitals = new string(RemoveAllButCapitals(secondLine.ToUpper()).ToArray());
            firstLine = IterateThroughCharacters(firstLine, secondLine);
            return IterateThroughCharacters(firstLine, secondLineCapitals);
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-10-17 13:03:07</DateOfCreation>
        /// <summary>
        /// Loops through characters in second line.
        /// </summary>
        /// <param name="firstLine">Line where characters must be doubled.</param>
        /// <param name="secondLine">Line with characters that must be doubled.</param>
        /// <returns>Line with doubled characters.</returns>
        public string IterateThroughCharacters(string firstLine, string secondLine)
        {
            for (var i = 0; i < secondLine.Length; i++)
            {
                var character = secondLine.Substring(i, 1);
                firstLine = DoubleCharacter(firstLine, character);
            }
            return firstLine;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-10-17 13:03:39</DateOfCreation>
        /// <summary>
        ///  Doubles in first line a character that exists in second line.
        /// </summary>
        /// <param name="firstLine">Line where character must be doubled.</param>
        /// <param name="character">Character that must be doubled.</param>
        /// <returns>Line where each instance of given character is doubled.</returns>
        public string DoubleCharacter(string firstLine, string character)
        {
            var resultingLine = new StringBuilder();
            while (firstLine.Contains(character))
            {
                var characterIndex = firstLine.IndexOf(character);
                var characterCount = characterIndex + 2;
                firstLine = firstLine.Insert(characterIndex + 1, character);
                resultingLine = resultingLine.Insert(resultingLine.Length, firstLine.Substring(0, characterCount));
                firstLine = firstLine.Remove(0, characterCount);
            }
            resultingLine.Append(firstLine);
            return resultingLine.ToString();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-09-30 15:21:31</DateOfCreation>
        /// <summary>
        /// Returns line or closes the application.
        /// </summary>
        /// <param name="secondLine">Second console line.</param>
        /// <returns>Second console line.</returns>
        public string CheckForEsc(string secondLine)
        {
            if (secondLine == "Esc")
            {
                Environment.Exit(0);
            }
            return secondLine;
        }
    }
}
