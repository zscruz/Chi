using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Zhaxx.Chi
{
    public static class Stat
    {
        /// <summary>
        /// Calculates the arithmetic mean of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Arithmetic mean of data in the collection. Returns null for an empty collection.</returns>
        /// <remarks>Formula: Mean = Σ(x) / n where n is the number of data values.</remarks>
        public static double? Mean(IEnumerable<double> data)
        {
            if (data == null || !data.Any())
            {
                return null;
            }

            return data.Average(datum => datum);
        }

        /// <summary>
        /// Calculates the median value of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the median value. Returns null if collection is empty.</returns>
        public static double? Median(IEnumerable<double> data)
        {
            if (data == null || !data.Any())
            {
                return null;
            }

            var sortedData = data.OrderBy(x => x);
            var count = sortedData.Count();
            if (count % 2 == 0)
            {
                var leftIndex = count / 2 - 1;
                var leftValue = sortedData.ElementAt(leftIndex);
                var rightValue = sortedData.ElementAt(leftIndex + 1);
                return (leftValue + rightValue) / 2;
            }
            else
            {
                return sortedData.ElementAt(count / 2);
            }
        }

        /// <summary>
        /// Calculates the mode of the passed in data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <remarks>The mode is the data value that has the highest frequency. This assumes that the data collection is unimodal.</remarks>
        public static double? Mode(IEnumerable<double> data)
        {
            return null;
        }

        /// <summary>
        /// Calculates the variance of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the calculated variance value. Returns null if the collection is empty.</returns>
        /// <remarks>Fromula: σ^2 = Σ((x - μ)^2) / n </remarks>
        public static double? Variance(IEnumerable<double> data)
        {
            return null;
        }

        /// <summary>
        /// Finds the largest value in the collection. 
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the maximum value of the collection. Returns null for an empty collection.</returns>
        public static double? Max(IEnumerable<double> data)
        {
            return null;
        }

        /// <summary>
        /// Finds the smallest value in the collection.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the minimum value of the collection. Returns null for an empty collection.</returns>
        public static double? Min(IEnumerable<double> data)
        {
            return null;
        }
    }
}
