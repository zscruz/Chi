using System;
using System.Collections.Generic;
using System.Linq;

namespace Zhaxx.Chi
{
    public static partial class Stat
    {
        /// <summary>
        /// Calculates the population variance of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the population variance or null if collection is null or less than 2 values.</returns>
        /// <remarks>Formula: σ^2 = [ Σ(x - μ)^2 / n ]</remarks>
        public static double? PopulationVariance(IEnumerable<double> data)
        {
            if (data.IsNullOrLessThanTwo())
            {
                return null;
            }

            var mean = Mean(data).Value;

            var numerator = data.Sum(d => Math.Pow(d - mean, 2));

            return numerator / data.Count();
        }

        /// <summary>
        /// Calculates the standard variance of the passed in data.
        /// </summary>
        /// <param name="data">Collection of data.</param>
        /// <returns>Returns the sample variance or null if collection is null or less than 2 values.</returns>
        /// <remarks>Formula: s^2 = [ Σ(x - μ)^2 / n - 1 ]</remarks>
        public static double? SampleVariance(IEnumerable<double> data)
        {
            if (data.IsNullOrLessThanTwo())
            {
                return null;
            }

            var mean = Mean(data).Value;

            var numerator = data.Sum(d => Math.Pow(d - mean, 2));

            return numerator / (data.Count() - 1);
        }
    }
}
