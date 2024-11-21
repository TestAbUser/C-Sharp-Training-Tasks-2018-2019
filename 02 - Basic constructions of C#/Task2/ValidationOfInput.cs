using System;
using System.Linq;

namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 19:02:49</DateOfCreation>
    /// <summary>
    /// Validates the value entered into Console for N number.
    /// </summary>
    public class ValidationOfInput
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 19:05:30</DateOfCreation>
        /// <summary>
        /// Returns 'true' if the number is valid or 'false' if not.
        /// </summary>
        /// <param name="line">String value.</param>
        /// <returns>Integer value.</returns>
        public int ReturnValidatedNumber(string line)
        {
            int number = 0;
            if (ValidateOneNumberIsEntered(line.Split()))
            {
                number = Convert.ToInt32(line);
            }
            return number;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 19:07:09</DateOfCreation>
        /// <summary>
        /// Checks that only one number has been entered into Console.
        /// </summary>
        /// <param name="line">String array.</param>
        /// <returns>"True" if one number is entered.</returns>
        public bool ValidateOneNumberIsEntered(string[] line)
        {
            var check = false;
            if (line.Length == 1)
            {
                check = ValidateNumberIsInt(line.First());
            }
            else
            {
                Console.Error.WriteLine("Only one number allowed.");
            }
            return check;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 19:11:36</DateOfCreation>
        /// <summary>
        /// Checks that the value entered into Console is integer.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <returns>"True" if value is integer.</returns>
        public bool ValidateNumberIsInt(string value)
        {
            var isInt = Int32.TryParse(value, out int number);
            if (isInt)
            {
                isInt = ValidateNumberIsPositive(number);
            }
            else
            {
                Console.WriteLine("Number must be integer.");
            }
            return isInt;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-29 12:34:21</DateOfCreation>
        /// <summary>
        /// Checks that the number entered into Console is not negative.
        /// </summary>
        /// <param name="number">Integer value.</param>
        /// <returns>"True" if value is not negative.</returns>
        public bool ValidateNumberIsPositive(int number)
        {
            var isPositive = false;
            if (number >= 0)
            {
                isPositive = true;
            }
            else
            {
                Console.Error.WriteLine("Number must be positive");
            }
            return isPositive;
        }
    }
}
