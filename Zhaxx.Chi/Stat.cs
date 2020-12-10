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
    }
}
