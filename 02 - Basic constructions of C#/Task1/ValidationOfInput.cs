using System;
using System.Linq;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 14:26:41</DateOfCreation>
    /// <summary>
    /// Validates the values entered into Console for the sides of the rectangle. 
    /// </summary>
    public class ValidationOfInput
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 15:14:59</DateOfCreation>
        /// <summary>
        /// Returns validated values for the sides of the rectangle.
        /// </summary>
        /// <param name="line">String value from Console.</param>
        /// <returns>Integer array.</returns>
        public int[] ReturnValidatedSides(string line)
        {
            int[] sides = new int[2];
            if (ValidateThereAreTwoSides(line.Split()))
            {
                sides = Array.ConvertAll(line.Split(), int.Parse);
            }
            return sides;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 15:15:33</DateOfCreation>
        /// <summary>
        /// Checks that two values have been entered into Console.
        /// </summary>
        /// <param name="numberOfSides">Integer array.</param>
        /// <returns>"True" if two numbers entered.</returns>
        public bool ValidateThereAreTwoSides(string[] numberOfSides)
        {
            var valid = false;
            if (numberOfSides.Length == 2)
            {
                var sideA = numberOfSides.First();
                var sideB = numberOfSides.Last();
                valid = ValidateSidesAreInt(sideA, sideB);
            }
            else
            {
                Console.Error.WriteLine("Enter two values for the sides A and B.");
            }
            return valid;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 15:17:17</DateOfCreation>
        /// <summary>
        /// Checks that the values entered into Console are integer.
        /// </summary>
        /// <param name="valueForSideA">Side A.</param>
        /// <param name="valueForSideB">Side B.</param>
        /// <returns>"True" if values are integer.</returns>
        public bool ValidateSidesAreInt(string valueForSideA, string valueForSideB)
        {
            var check = false;
            var sideA = Int32.TryParse(valueForSideA, out int numberA);
            var sideB = Int32.TryParse(valueForSideB, out int numberB);
            if (sideA & sideB)
            {
                check = ValidateSidesArePositive(numberA, numberB);
            }
            else
            {
                Console.WriteLine("Sides must be integer!");
            }
            return check;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 15:25:24</DateOfCreation>
        /// <summary>
        /// Checks that the values entered into Console are not negative.
        /// </summary>
        /// <param name="sideA">Side A.</param>
        /// <param name="sideB">Side B.</param>
        /// <returns>"True" if values are not negative.</returns>
        public bool ValidateSidesArePositive(int sideA, int sideB)
        {
            var check = false;
            if ((sideA >= 0) & (sideB >= 0))
            {
                check = true;
            }
            else
            {
                Console.Error.WriteLine("Number must be positive");
            }
            return check;
        }
    }
}
