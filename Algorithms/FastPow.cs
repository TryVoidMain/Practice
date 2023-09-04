namespace NumericAlgorithms
{
    public static class FastPow
    {

        /// <summary>
        /// Method powers input number with reccurent function
        /// </summary>
        /// <param name="num"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static long FindFastPow(long num, long power)
        {
            if (power == 0)
                return 1;

            if (power % 2 == 0)
            {
                var res = FindFastPow(num, power / 2);
                if (Validate(res))
                    return res * res;
                else
                    throw new ArgumentOutOfRangeException(nameof(res));
            }
            else
            {
                var res = num * FindFastPow(num, power - 1);
                if (Validate(res))
                    return res;
                else 
                    throw new ArgumentOutOfRangeException(nameof(res));
            }
        }

        public static bool Validate(long value)
        {
            if (value < 0)
                return false;

            return true;
        }
    }
}
