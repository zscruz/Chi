using System.Collections.Generic;
using System.Linq;

namespace Zhaxx.Chi
{
    internal static class IEnumerableExtensions
    { 
        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> data)
        {
            return data == null || !data.Any();
        }

        internal static bool IsNullOrLessThanTwo<T>(this IEnumerable<T> data)
        {
            return data == null || data.Count() < 2;
        }
    }
}
