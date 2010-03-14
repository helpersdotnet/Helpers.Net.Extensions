using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace Helpers.Net.Extensions.Tests
{
    public class CharTests
    {
        #region Data
        public static IEnumerable<object[]> VowelsSmall
        {
            get
            {
                yield return new object[] { 'a' };
                yield return new object[] { 'e' };
                yield return new object[] { 'i' };
                yield return new object[] { 'o' };
                yield return new object[] { 'u' };
            }
        }
        public static IEnumerable<object[]> VowelsBig
        {
            get
            {
                yield return new object[] { 'A' };
                yield return new object[] { 'E' };
                yield return new object[] { 'I' };
                yield return new object[] { 'O' };
                yield return new object[] { 'U' };
            }
        }
        public static IEnumerable<object[]> ConsonantsSmall
        {
            get
            {
                yield return new object[] { 'b' };
                yield return new object[] { 'c' };
                yield return new object[] { 'd' };
                yield return new object[] { 'f' };
                yield return new object[] { 'g' };
                yield return new object[] { 'h' };
                yield return new object[] { 'j' };
                yield return new object[] { 'k' };
                yield return new object[] { 'l' };
                yield return new object[] { 'm' };
                yield return new object[] { 'n' };
                yield return new object[] { 'p' };
                yield return new object[] { 'q' };
                yield return new object[] { 'r' };
                yield return new object[] { 's' };
                yield return new object[] { 't' };
                yield return new object[] { 'v' };
                yield return new object[] { 'w' };
                yield return new object[] { 'x' };
                yield return new object[] { 'y' };
                yield return new object[] { 'z' };
            }
        }
        public static IEnumerable<object[]> ConsonantsBig
        {
            get
            {
                yield return new object[] { 'B' };
                yield return new object[] { 'C' };
                yield return new object[] { 'D' };
                yield return new object[] { 'F' };
                yield return new object[] { 'G' };
                yield return new object[] { 'H' };
                yield return new object[] { 'J' };
                yield return new object[] { 'K' };
                yield return new object[] { 'L' };
                yield return new object[] { 'M' };
                yield return new object[] { 'N' };
                yield return new object[] { 'P' };
                yield return new object[] { 'Q' };
                yield return new object[] { 'R' };
                yield return new object[] { 'S' };
                yield return new object[] { 'T' };
                yield return new object[] { 'V' };
                yield return new object[] { 'W' };
                yield return new object[] { 'X' };
                yield return new object[] { 'Y' };
                yield return new object[] { 'Z' };
            }
        }
        #endregion

        #region Tests

        /// <summary>
        /// A test for is vowel
        /// </summary>
        /// <param name="c">char to test</param>
        [Theory]
        [PropertyData("VowelsSmall")]
        [PropertyData("VowelsBig")]
        public void IsVowelTest_True(char c)
        {
            Assert.True(c.IsVowel());
        }

        [Theory]
        [PropertyData("ConsonantsSmall")]
        [PropertyData("ConsonantsBig")]
        public void IsVowelTest_False(char c)
        {
            Assert.False(c.IsVowel());
        }

        [Theory]
        [PropertyData("ConsonantsSmall")]
        [PropertyData("ConsonantsBig")]
        public void IsConsonantTest_True(char c)
        {
            Assert.True(c.IsConsonant());
        }

        [Theory]
        [PropertyData("VowelsSmall")]
        [PropertyData("VowelsBig")]
        public void IsConsonantTest_False(char c)
        {
            Assert.True(c.IsVowel());
        }

        #endregion
    }
}
