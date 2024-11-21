using System;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-05 12:10:07</DateOfCreation>
    /// <summary>
    /// Contains methods that display the menu and the results in Console.
    /// </summary>
    public class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:10:07</DateOfCreation>
        /// <summary>
        /// Displays the menu in Console.
        /// </summary>
        public void PrintMenu()
        {
            Console.WriteLine("1.To compare cultures, type any two of the following abbreviations and press 'Enter': US, GB, RU, FR, DE." +
                              "\nFor example: US vs FR." +
                              "\n2.To exit, type 'Esc' and press 'Enter'.");

        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:10:07</DateOfCreation>
        /// <summary>
        /// Displays the header of the table in Console.
        /// </summary>
        public void PrintHeader()
        {
            Console.WriteLine("----------------------------------------------------" +
                              "\n Cultures |      Time Format       | Number Format |" +
                              "\n----------------------------------------------------");
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:10:07</DateOfCreation>
        /// <summary>
        /// Displays the formatted values in Console.
        /// </summary>
        /// <param name="cultureNames">String array of culture names.</param>
        public void PrintFormattedValues(string[] cultureNames)
        {
            foreach (var cultureName in cultureNames)
            {
                Console.WriteLine(cultureName);
            }
            if (cultureNames.Length == 0)
            {
                PrintError();
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-05 12:10:07</DateOfCreation>
        /// <summary>
        /// Displays an error message in Console.
        /// </summary>
        public void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Incorrect data entered. Please use the values given in the Menu.");
            Console.ResetColor();
        }
    }
}
