using System;
using System.Collections.Generic;

namespace Zhaxx.Chi
{
    public static partial class Stat
    {
        /// <summary>
        /// Calculates the population standard deviation of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the population standard deviation or null if collection is null or less than 2 values.</returns>
        /// <remarks>Formula: σ = Square-root(population-variance)</remarks>
        public static double? PopulationStandardDeviation(IEnumerable<double> data)
        {
            if (data.IsNullOrLessThanTwo())
            {
                return null;
            }

            var variance = PopulationVariance(data);

            return Math.Sqrt(variance.Value);
        }

        /// <summary>
        /// Calculates the sample standard deviation of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the sample standard deviation or null if collection is null or less than 2 values.</returns>
        /// <remarks>Formula: s = Square-root(sample-variance)</remarks>
        public static double? SampleStandardDeviation(IEnumerable<double> data)
        {
            if (data.IsNullOrLessThanTwo())
            {
                return null;
            }

            var variance = SampleVariance(data);

            return Math.Sqrt(variance.Value);
        }
    }
}
