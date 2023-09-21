using Algorithms.Helpers;

namespace Algorithms.NumericalAlgorithms
{
    public class NumericalIntegration
    {
        /// <summary>
        /// Approximation area of function with rectangles. Alternative to integrals.
        /// </summary>
        /// <param name="function">function, which area should be calculated</param>
        /// <param name="numIntervals">number of intervals which separate start/end point on equal segments</param>
        /// <returns>Calculated area of function</returns>
        public static float RectangleRule(IntegratedFunction function, int numIntervals)
        {
            float dx = function.Segment / numIntervals;
            float resultArea = 0;

            float x = function.XMin;
            for (int i = 0; i < numIntervals; i++)
            {
                resultArea += dx * function.Function.Invoke(x);
                x += dx;
            }

            return resultArea;
        }

        /// <summary>
        /// Approximation area of function with trapezoid. Alternative to integrals.
        /// </summary>
        /// <param name="function">function, which area should be calculated</param>
        /// <param name="numIntervals">number of intervals which separate start/end point on equal segments</param>
        /// <returns>Calculated area of function</returns>
        public static float TrapezoidRule(IntegratedFunction function, int numIntervals)
        {
            float dx = function.Segment / numIntervals;
            float resultArea = 0;

            float x = function.XMin;
            for (int i = 0; i < numIntervals; i++)
            {
                resultArea += dx * (function.Function.Invoke(x) + function.Function.Invoke(x + dx)) / 2;
                x += dx;
            }

            return resultArea;
        }

        #region Adaptive trapezoid function integration

        /// <summary>
        /// Approximation area of function with adaptive trapezoid. More progressive and rough way to calculate area of function
        /// </summary>
        /// <param name="function">function, which area should be calculated</param>
        /// <param name="numIntervals">number of intervals which separate start/end point on equal segments</param>
        /// <returns>Calculated area of function</returns>
        public static float IntegrateAdaptiveMidpoint(IntegratedFunction function, int numIntervals, float maxSliceError)
        {
            float dx = function.Segment / numIntervals;

            float totalArea = 0;
            float x = function.XMin;

            for (int i = 1; i <= numIntervals; i++)
            {
                totalArea += SliceArea(new IntegratedFunction(function.Function, x, x + dx), maxSliceError);
                x += dx;
            }

            return totalArea;
        }


        /// <summary>
        /// Function-helper to <see cref="IntegrateAdaptiveMidpoint"/>. Slices input area to get required accuracy
        /// </summary>
        /// <param name="function"></param>
        /// <param name="maxSliceError"></param>
        /// <returns></returns>
        public static float SliceArea(IntegratedFunction function, float maxSliceError)
        {
            float y1 = function.Function.Invoke(function.XMin);
            float y2 = function.Function.Invoke(function.XMax);
            float xm = (function.XMin + function.XMax) / 2;
            float ym = function.Function.Invoke(xm);

            float area12 = (function.XMax - function.XMin) * (y1 + y2) / 2;
            float area1m = (xm - function.XMin) * (y1 + ym) / 2;
            float aream2 = (function.XMax - xm) * (ym + y2) / 2;
            float area1m2 = area1m + aream2;

            float error = (area1m2 - area12) / area12;
            if (Math.Abs(error) < maxSliceError)
                return area1m2;

            return SliceArea(new IntegratedFunction(function.Function, function.XMin, xm), maxSliceError) +
                    SliceArea(new IntegratedFunction(function.Function, xm, function.XMax), maxSliceError);
        }

        #endregion
    }
}
