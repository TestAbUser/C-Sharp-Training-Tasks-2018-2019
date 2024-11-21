namespace Task3
{
    /// <summary>
    /// Contains methods performing different operations with the array.
    /// </summary>
    public class ArrayHandler : Task1.ArrayHandler
    {
        /// <summary>
        /// Calculates the sum of all positive numbers in the array.
        /// </summary>
        /// <param name="array">Integer array.</param>
        /// <returns>Sum of elements.</returns>
        public int SumPositiveElements(int[] array)
        {
            int sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
