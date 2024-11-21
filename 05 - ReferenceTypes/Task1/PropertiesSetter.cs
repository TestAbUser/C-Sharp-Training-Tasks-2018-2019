using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:06:36</DateOfCreation>
    /// <summary>
    /// Contains classes that help to set User properties.
    /// </summary>
    public static class PropertiesSetter
    {

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:41:43</DateOfCreation>
        /// <summary>
        /// Extracts a date from a line.
        /// </summary>
        /// <param name="line">Used for parsing.</param>
        /// <returns>Date.</returns>
        public static DateTime GetDateFromLine(string line)
        {
            var date = default(DateTime);
            if (DateTime.TryParse(line, out DateTime parsedLine))
            {
                date = parsedLine;
            }
            else
            {
                Logger.PrintNotDateWarning();
            }
            return date;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:45:18</DateOfCreation>
        /// <summary>
        /// Checks that the date is in the past.
        /// </summary>
        /// <param name="date">The entered date.</param>
        /// <returns>Date.</returns>
        public static DateTime GetBirthDate(DateTime date)
        {
            var birthDate = default(DateTime);
            if (IsBeforeThisYear(date) || (IsThisYear(date) && IsBeforeToday(date)))
            {
                birthDate = date;
            }
            else
            {
                Logger.PrintTooBigDateWarning();
            }
            return birthDate;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:45:30</DateOfCreation>
        /// <summary>
        /// Checks whether the entered date is before this year or not.
        /// </summary>
        /// <param name="date">The entered date.</param>
        /// <returns>True or false.</returns>
        public static bool IsBeforeThisYear(DateTime date) => date.Year < DateTime.Now.Year;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:45:42</DateOfCreation>
        /// <summary>
        /// Checks whether the entered date is this year or not.
        /// </summary>
        /// <param name="date">The entered date.</param>
        /// <returns>True or false.</returns>
        public static bool IsThisYear(DateTime date) => date.Year == DateTime.Now.Year;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-11-12 19:45:54</DateOfCreation>
        /// <summary>
        /// Checks whether the entered date is before today or not.
        /// </summary>
        /// <param name="date">The entered date.</param>
        /// <returns>True or false.</returns>
        public static bool IsBeforeToday(DateTime date) => date.DayOfYear <= DateTime.Now.DayOfYear;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-09 01:02:35</DateOfCreation>
        /// <summary>
        /// Prompts the user to enter the first name.
        /// </summary>
        /// <returns>String value.</returns>
        public static string SetFirstName()
        {
            Console.WriteLine("First Name:");
            return Console.ReadLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-09 01:03:04</DateOfCreation>
        /// <summary>
        /// Prompts the user to enter the second name.
        /// </summary>
        /// <returns>String value.</returns>
        public static string SetSecondName()
        {
            Console.WriteLine("Second Name:");
            return Console.ReadLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-09 01:03:22</DateOfCreation>
        /// <summary>
        /// Prompts the user to enter the surname.
        /// </summary>
        /// <returns>String value.</returns>
        public static string SetSurname()
        {
            Console.WriteLine("Surname:");
            return Console.ReadLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-09 01:03:42</DateOfCreation>
        /// <summary>
        /// Prompts the user to enter the date of the birth.
        /// </summary>
        /// <returns>String value.</returns>
        public static DateTime SetBirthDate()
        {
            Console.WriteLine("Date of Birth:");
            DateTime date = GetDateFromLine(Console.ReadLine());
            return GetBirthDate(date);
        }
    }
}
