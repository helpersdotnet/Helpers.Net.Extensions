using System.Collections;
using System.Collections.Generic;

namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>hellow
        /// Indicates wheter the specified <see cref="System.Collections.ICollection"/>
        /// is null or empty.
        /// </summary>
        /// <param name="icollection"><see cref="System.Collections.ICollection"/>
        ///     to check for.</param>
        /// <returns>Return true if Count is 0 or it is null</returns>
        public static bool IsNullOrEmpty(this ICollection icollection)
        {
            return (icollection == null || icollection.Count == 0);
        }

        /// <summary>
        /// Indicates wheter the specified ICollection&lt;T>
        /// is null or empty.
        /// </summary>
        /// <typeparam name="T">The type of the collection.</typeparam>
        /// <param name="icollection">collection</param>
        /// <returns>
        ///     <c>true</c> if the collection is null or empty,
        ///     otherwise <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> icollection)
        {
            return (icollection == null || icollection.Count == 0);
        }

    }
}
