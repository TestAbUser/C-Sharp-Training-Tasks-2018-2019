
namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-03-11 21:10:27</DateOfCreation>
    /// <summary>
    /// Contains Main() method used as the entry point of the program.
    /// </summary>
    public class Program
    {
        private const int MaximalNumber = 1000;
        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-03-11 21:10:27</DateOfCreation>
        /// <summary>
        /// Calls the methods that calculate the sum and display it in Console. 
        /// </summary>
        static void Main()
        {
            var calculationOfSum = new CalculationOfSum();
            Logging logging = new Logging();
            var sum = calculationOfSum.CalculateSum(MaximalNumber);
            logging.PrintSumToConsole(sum);
        }
    }
}
