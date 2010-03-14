
namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Checks whether the number is even or not.
        /// </summary>
        /// <param name="i">The number to check.</param>
        /// <returns>Returns true if the number is even.</returns>
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        /// <summary>
        /// Checks wheter the number is odd or not.
        /// </summary>
        /// <param name="i">The number to check.</param>
        /// <returns>Returns true if the number is odd.</returns>
        /// <remarks>
        /// Instead of doing !IsEven(), we write the whole line to
        /// prevent function calling overhead.
        /// </remarks>
        public static bool IsOdd(this int i)
        {
            return i % 2 != 0;
        }
    }
}
