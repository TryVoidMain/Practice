namespace Algorithms.NumericalAlgorithms
{
    public class GreatestCommonDivisors
    {
        /// <summary>
        /// Class provides methods to find common divisors
        /// </summary>
        public GreatestCommonDivisors() { }

        /// <summary>
        /// This method finds greatest common divisors for two input values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int FindGreatestCommonDivisors(int x, int y)
        {
            int max = Math.Max(x, y);
            int min = Math.Min(x, y);

            while (min != 0)
            {
                var remainder = max % min;
                max = min;
                min = remainder;
            }

            return max;
        }
    }
}
