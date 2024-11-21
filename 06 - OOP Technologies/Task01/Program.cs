using System;
using System.Text;

namespace Task01
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 11:40:24</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-05-29 11:40:52</DateOfCreation>
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            Logger.PrintMenu();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Employee employee = new Employee();
                        Logger.AppendToFile(employee);
                        break;
                    case ConsoleKey.D2:
                        StringBuilder text = Task1.Logger.ReadConsoleLines();
                        Task1.Logger.OverwriteFile(text.ToString());
                        break;
                    case ConsoleKey.D3:
                        Task1.Logger.ReadFromFile();
                        break;
                    default:
                        Logger.PrintIncorrectOptionWarning();
                        break;
                }
                Logger.PrintMenu();
            } while (key != ConsoleKey.Escape);
        }
    }
}
