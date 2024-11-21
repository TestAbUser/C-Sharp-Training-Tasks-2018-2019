using System;
using Task01.Properties;

namespace Task01
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-06-05 15:47:44</DateOfCreation>
    /// <summary>
    /// Contains methods validating the entered data.
    /// </summary>
    public static class PropertiesSetter
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-05-02</DateOfCreation>
        /// <summary>
        /// Returns the date of hire after its validation.
        /// </summary>
        /// <param name="unvalidatedHiringdate">Used for the age calculation.</param>
        /// <param name="birthDate">Used for the age calculation.</param>
        /// <returns>The date of hire.</returns>
        public static DateTime GetHiringDate(DateTime unvalidatedHiringdate, DateTime birthDate)
        {
            int age = GetAgeWhenHired(unvalidatedHiringdate, birthDate);
            var hiringDate = default(DateTime);
            if (birthDate != default && IsFullLegalAgeWhenHired(age))
            {
                hiringDate = unvalidatedHiringdate;
            }
            return hiringDate;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-04-30</DateOfCreation>
        /// <summary>
        /// Verifies that a person was of full legal age at the time of hire.
        /// </summary>
        /// <param name="age">Used for comparison with the full legal age.</param>
        /// <returns>True if a person is of full legal age, otherwise - false.</returns>
        public static bool IsFullLegalAgeWhenHired(int age)
        {
            var isFullLegalAge = false;
            var fullLegalAge = 18;
            if (age >= fullLegalAge)
            {
                isFullLegalAge = true;
            }
            else
            {
                Logger.PrintUnderageWarning();
            }
            return isFullLegalAge;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-04-30</DateOfCreation>
        /// <summary>
        /// Calculates a person's age at the time of hire.
        /// </summary>
        /// <param name="hiringDate">Used for calculating the age.</param>
        /// <param name="birthDate">Used for calculating the age.</param>
        /// <returns>The age at the time of hire.</returns>
        public static int GetAgeWhenHired(DateTime hiringDate, DateTime birthDate)
        {
            var age = hiringDate.Year - birthDate.Year;
            if (hiringDate.DayOfYear < birthDate.DayOfYear && age >= 1)
            {
                age -= 1;
            }
            return age;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 16:00:28</DateOfCreation>
        /// <summary>
        /// Returns the work experience after checking that the date of hiring is not null.
        /// </summary>
        /// <param name="hiringDate">Used for calculating the work experience.</param>
        /// <returns>The date of hire.</returns>
        public static int GetWorkExperience(DateTime hiringDate)
        {
            int workExperience = 0;
            if (hiringDate != default)
            {
                workExperience = DateTime.Now.Year - hiringDate.Year;
                if (hiringDate.DayOfYear > DateTime.Now.DayOfYear && workExperience >= 1)
                {
                    workExperience -= 1;
                }
            }
            return workExperience;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-04-30</DateOfCreation>
        /// <summary>
        /// Prompts to enter an employee's position.
        /// </summary>
        /// <returns>An employee's position.</returns>
        public static string SetPosition()
        {
            Console.WriteLine(Resources.Position);
            return Console.ReadLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-04-30</DateOfCreation>
        /// <summary>
        /// Prompts to enter the date of hire.
        /// </summary>
        /// <returns>The date of hire.</returns>
        public static DateTime SetHiringDate()
        {
            Console.WriteLine(Resources.DateOfHiring);
            DateTime hiringDate = Task1.PropertiesSetter.GetDateFromLine(Console.ReadLine());
            return hiringDate;
        }
    }
}
