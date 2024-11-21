using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:09:15</DateOfCreation>
    /// <summary>
    /// Contains methods that calculate the user's age.
    /// </summary>
    public static class AgeCalculator
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:34:37</DateOfCreation>
        /// <summary>
        /// Calculates the age of the user.
        /// </summary>
        /// <param name="date">Date of birth.</param>
        /// <returns>Age.</returns>
        public static int CalculateAge(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            age = PreciseAge(date, age);
            return age;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:35:11</DateOfCreation>
        /// <summary>
        /// Corrects the age depending on wheteher the day of birthday is before or after the current day.
        /// </summary>
        /// <param name="birthDate">Used for age calculation.</param>
        /// <param name="approximateAge">Used for age calculation.</param>
        /// <returns>Age.</returns>
        public static int PreciseAge(DateTime birthDate, int approximateAge)
        {
            int age = approximateAge;
            if (IsAfterToday(birthDate))
            {
                age = SubtractOneYear(age);
            }
            return age;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:35:30</DateOfCreation>
        /// <summary>
        /// Checks wheteher the day of birthday is before or after the current day.
        /// </summary>
        /// <param name="dateOfBirth">Used to find out the birth day.</param>
        /// <returns>True or false.</returns>
        public static bool IsAfterToday(DateTime dateOfBirth) => dateOfBirth.DayOfYear > DateTime.Now.DayOfYear;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:35:49</DateOfCreation>
        /// <summary>
        /// Subtracts a year from the age if it is bigger than a year.
        /// </summary>
        /// <param name="age">The age before subtraction.</param>
        /// <returns>Age.</returns>
        public static int SubtractOneYear(int age)
        {
            if (age >= 1)
            {
                age -= 1;
            }
            return age;
        }
    }
}
