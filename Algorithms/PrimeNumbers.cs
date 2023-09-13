namespace NumericAlgorithms
{

    public class PrimeNumbers
    {
        /// <summary>
        /// Class provides methods for different calculations with prime numbers
        /// </summary>
        public PrimeNumbers() { }


        /// <summary>
        /// Method finds prime multipliers of input numbers. Algoritmic complexity O(N).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<int> FindFactors(int number)
        {
            List<int> result = new List<int>();
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
        /// Method finds prime multipliers of input numbers. Algoritmic complexity O(sqrt(N)).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<int> FindFactorsFaster(int number)
        {
            List <int> result = new List<int>();
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
    }
}
