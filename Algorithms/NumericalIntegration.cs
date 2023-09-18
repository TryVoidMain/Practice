
namespace NumericAlgorithms
{
    public class NumericalIntegration
    {
        /// <summary>
        /// Approximation area of function with rectangles. Alternative to integrals.
        /// </summary>
        /// <param name="function">function, which area should be calculated</param>
        /// <param name="xMin">start calculation point of function</param>
        /// <param name="xMax">end calculation point of function</param>
        /// <param name="numIntervals">number of intervals which separate start/end point on equal segments</param>
        /// <returns>Calculated area of function</returns>
        public static float RectangleRule(Func<float, float> function, float xMin, float xMax, int numIntervals)
        {
            float dx = (xMax - xMin) / numIntervals;
            float resultArea = 0;

            float x = xMin;
            for (int i = 0; i < numIntervals; i++)
            {
                resultArea += dx * function(x);
                x += dx;
            }

            return resultArea;
        }

        /// <summary>
        /// Approximation area of function with trapezoid. Alternative to integrals.
        /// </summary>
        /// <param name="function">function, which area should be calculated</param>
        /// <param name="xMin">start calculation point of function</param>
        /// <param name="xMax">end calculation point of function</param>
        /// <param name="numIntervals">number of intervals which separate start/end point on equal segments</param>
        /// <returns>Calculated area of function</returns>
        public static float TrapezoidRule(Func<float, float> function, float xMin, float xMax, int numIntervals)
        {
            float dx = (xMax - xMin) / numIntervals;
            float resultArea = 0;

            float x = xMin;
            for (int i = 0; i < numIntervals; i++)
            {
                resultArea += dx * (function(x) + function(x + dx)) / 2;
                x += dx;
            }

            return resultArea;
        }
    }
}
