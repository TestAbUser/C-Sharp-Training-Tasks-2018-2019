using System;

namespace ConsoleApp
{
    /// <summary>
    /// the class contains the Main method which checks that no fewer than 5 parameters are 
    /// entered and displays them in Console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                args = line.Split();

                if (args.Length < 5)
                {
                    Console.WriteLine("There should be 5 arguments");
                }
                else
                    break;
            }

            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.ReadLine();
        }
    }
}
