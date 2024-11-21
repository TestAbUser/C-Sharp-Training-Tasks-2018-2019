using System;
using System.Text;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:08:45</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public static class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:08:45</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        public static void Main()
        {
            Logger.PrintMenu();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        User user = new User();
                        Logger.AppendToFile(user);
                        break;
                    case ConsoleKey.D2:
                        StringBuilder text = Logger.ReadConsoleLines();
                        Logger.OverwriteFile(text.ToString());
                        break;
                    case ConsoleKey.D3:
                        Logger.ReadFromFile();
                        break;
                    default:
                        break;
                }
                Logger.PrintMenu();
            } while (key != ConsoleKey.Escape);
        }
    }
}

