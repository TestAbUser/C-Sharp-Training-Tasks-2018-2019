using System;
using System.IO;
using System.Text;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:07:36</DateOfCreation>
    /// <summary>
    /// Contains methods for displaying different menu options and warnings in Console.
    /// </summary>
    public static class Logger
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:07:36</DateOfCreation>
        /// <summary>
        /// Displays Menu in Console.
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu:" +
                              "\nType the number of the option you want to select, then press 'Enter':" +
                              "\n1.Enter the following information: First Name, Second Name, Surname, Date of Birth (MM/dd/yyyy)" +
                              "\n2.Overwrite the file." +
                              "\n3.Read from file." +
                              "\nTo exit, press 'ESC'.");
            Console.WriteLine();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-01-10 14:48:07</DateOfCreation>
        /// <summary>
        /// Reads pressed keys and appends them to a string.
        /// </summary>
        /// <returns>Multiline string.</returns>
        public static StringBuilder ReadConsoleLines()
        {
            PrintOverwriteFileOption();
            var stringBuilder = new StringBuilder();
            var key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Escape)
            {
                GoToNewLine(key);
                Console.Write(key.KeyChar);
                stringBuilder.Append(key.KeyChar);
                key = Console.ReadKey(true);
            }
            Console.WriteLine();
            return stringBuilder;
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-06 20:13:04</DateOfCreation>
        /// <summary>
        /// Performs carriage return whenever 'Enter' key is pressed.
        /// </summary>
        /// <param name="key">Used for comparison.</param>
        public static void GoToNewLine(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-20 12:35:15</DateOfCreation>
        /// <summary>
        /// Warns that the date of birth has not arrived yet.
        /// </summary>
        public static void PrintTooBigDateWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The date should be less than the current date!");
            Console.WriteLine();
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-24 13:03:50</DateOfCreation>
        /// <summary>
        /// Warns that the entered value is not a date.
        /// </summary>
        public static void PrintNotDateWarning()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The entered value is not a date!");
            Console.ResetColor();
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-01-10 14:48:48</DateOfCreation>
        /// <summary>
        /// Adds the information entered into Console to the file.
        /// </summary>
        /// <param name="user">Used for getting user information.</param>
        public static void AppendToFile(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            try
            {
                using (StreamWriter file = new StreamWriter(@".\UserInformation.rtf", true))
                {
                    file.WriteLine("{0, -20} {1} {2,-20} {3} {4,-20} {5} {6,-20} {7:D} {8,-20} {9}",
                                   "\nFirst Name:", user.FirstName,
                                   "\nSecond Name:", user.SecondName,
                                   "\nSurname:", user.Surname,
                                   "\nDate of Birth:", user.DateOfBirth,
                                   "\nAge:", user.Age);
                    file.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-01-10 14:49:42</DateOfCreation>
        /// <summary>
        /// Overwrites the file.
        /// </summary>
        /// <param name="text">New information from Console.</param>
        public static void OverwriteFile(string text)
        {
            try
            {
                using (var streamWriter = new StreamWriter(@".\UserInformation.rtf", false))
                {
                    streamWriter.WriteLine(text);
                    streamWriter.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-01-10 14:50:04</DateOfCreation>
        /// <summary>
        /// Reads the file and displays its content in Console.
        /// </summary>
        public static void ReadFromFile()
        {
            try
            {
                using (var reader = new StreamReader(@".\UserInformation.rtf"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2020-02-07 22:55:46</DateOfCreation>
        /// <summary>
        /// Prompts the user to enter information or return to Menu.
        /// </summary>
        public static void PrintOverwriteFileOption()
        {
            Console.WriteLine("Enter the data. Press 'Esc'to return to Main menu.");
            Console.WriteLine();
        }
    }
}
