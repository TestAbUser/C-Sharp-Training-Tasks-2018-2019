using System;
using System.IO;
using Task01.Properties;

namespace Task01
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 11:41:26</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different Menu options and warnings.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-23 13:23:16</DateOfCreation>
        /// <summary>
        /// Displays Menu.
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine(Resources.Menu);
            Console.WriteLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-04-29</DateOfCreation>
        /// <summary>
        /// Adds the information entered into Console to the file.
        /// </summary>
        /// <param name="employee">Used for getting employee's personal information.</param>
        public static void AppendToFile(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            try
            {
                using (StreamWriter file = new StreamWriter(@Resources.EmployeeInformationFile, true))
                {
                    file.WriteLine(Resources.PersonalInformation, employee.FirstName, employee.SecondName, employee.Surname,
                                   employee.Age, employee.Position, employee.WorkExperience);
                    file.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-24 18:34:24</DateOfCreation>
        /// <summary>
        /// Warns that the entered option does not exist.
        /// </summary>
        public static void PrintIncorrectOptionWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Resources.IncorrectOptionWarning);
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-29 11:41:59</DateOfCreation>
        /// <summary>
        /// Warns that the employee is underage.
        /// </summary>
        public static void PrintUnderageWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Resources.UnderageWarning);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
