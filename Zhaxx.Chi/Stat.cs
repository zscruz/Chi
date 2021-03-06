﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Zhaxx.Chi
{
    public static partial class Stat
    {
        /// <summary>
        /// Calculates the arithmetic mean of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Arithmetic mean of data in the collection. Returns null for an empty collection.</returns>
        /// <remarks>Formula: Mean = Σ(x) / n where n is the number of data values.</remarks>
        public static double? Mean(IEnumerable<double> data)
        {
            if (data.IsNullOrEmpty())
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
            if (data.IsNullOrEmpty())
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
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the mode.</returns>
        /// <remarks>The mode is the data value that has the highest frequency. This assumes that the data collection is unimodal.</remarks>
        public static double? Mode(IEnumerable<double> data)
        {
            if (data.IsNullOrEmpty())
            {
                return null;
            }

            var groups = data.GroupBy(d => d);
            int maxCount = groups.Max(g => g.Count());
            double mode = groups.First(g => g.Count() == maxCount).Key;

            return mode;
        }
    }
}
