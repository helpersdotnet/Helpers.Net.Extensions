using System;

namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts the string representation of a number to <see cref="System.Single"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns></returns>
        public static float ToFloat(this string str)
        {
            return float.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to <see cref="System.Int32"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to <see cref="System.Double"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns></returns>
        public static double ToDouble(this string str)
        {
            return double.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to <see cref="System.Decimal"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        /// <summary>
        /// Converts the string representation of a character to <see cref="System.Char"/> equivalent.
        /// </summary>
        /// <param name="s">String representation of the character to convert.</param>
        /// <returns></returns>
        public static char ToChar(this string s)
        {
            return char.Parse(s);
        }
    }
}
