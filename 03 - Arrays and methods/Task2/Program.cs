
namespace Task2
{
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Calls methods necessary for the execution of the program.
        /// </summary>
        static void Main()
        {
            ArrayHandler arrayHandler = new ArrayHandler();
            int[,,] array = arrayHandler.FillArray();
            array = arrayHandler.ReplacePositiveWithZero(array);
            Logger logger = new Logger();
            logger.PrintToConsole(array);
        }
    }
}
