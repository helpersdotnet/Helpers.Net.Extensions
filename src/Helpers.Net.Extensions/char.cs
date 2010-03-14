
namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Checks whether the character is a vowel or not.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Returns true if the character is vowel.</returns>
        public static bool IsVowel(this char c)
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Checks whether the character is a consonant or not.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Returns true if the character is consonant.</returns>
        public static bool IsConsonant(this char c)
        {
            return !c.IsVowel();
        }
    }
}
