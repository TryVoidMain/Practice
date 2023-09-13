using System.Net;

namespace NumericAlgorithms
{

    public class PrimeNumbers
    {
        /// <summary>
        /// Class provides methods for different calculations with prime numbers
        /// </summary>
        public PrimeNumbers() { }


        /// <summary>
        /// Method finds prime multipliers of input number. Algoritmic complexity O(N).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindPrimeFactors(int number)
        {
            var result = new List<int>();
            int i = 2;

            while (i < number)
            {
                while (number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                }

                i++;
            }

            if (number > 1)
                result.Add(number);

            return result;
        }

        /// <summary>
        /// Method finds prime multipliers of input number. Algoritmic complexity O(sqrt(N)).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindPrimeFactorsFaster(int number)
        {
            var result = new List<int>();
            int i = 2;
            
            if (number % i == 0)
            {
                result.Add(i);
                number /= i;
            }

            i = 3;
            int max_factor = (int)Math.Sqrt(number);

            while (i <= max_factor)
            {
                while (number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                    max_factor = (int)Math.Sqrt(number);
                }

                i += 2;
            }
            
            if (number > 1)
                result.Add(number);

            return result;
        }


        /// <summary>
        /// Method finds all prime numbers in input number. Algoritmic complexity O(N*log(log(N))).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindPrimesSieveOfEratosthenes(int number)
        {
            var isComposite = new bool[number + 1];
            for (int i = 4; i < number; i += 2)
                isComposite[i] = true;

            int nextPrime = 3;
            int stopAt = (int)Math.Sqrt(number);
            
            while (nextPrime  <= stopAt)
            {
                for (int i = nextPrime * 2; i < number; i+=nextPrime)
                    isComposite[i] = true;

                nextPrime += 2;

                while (nextPrime <= number && isComposite[nextPrime])
                    nextPrime += 2;
            }

            var result = new List<int>();
            for (int i = 2; i < number; i++)
                if (!isComposite[i])
                    result.Add(i);

            return result;
        }
    }
}
