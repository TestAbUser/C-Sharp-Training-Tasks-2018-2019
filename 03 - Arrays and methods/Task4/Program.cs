
namespace Task4
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
            int[,] array = arrayHandler.FillArray();
            int sum = arrayHandler.SumElementsInEvenPositions(array);
            Logger logger = new Logger();
            logger.PrintArrayToConsole(array);
            logger.PrintSumToConsole(sum);
        }
    }
}
