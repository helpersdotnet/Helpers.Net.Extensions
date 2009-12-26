using System;

namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts the string representation of a number to <see cref="System.Decimal"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }
    }
}
