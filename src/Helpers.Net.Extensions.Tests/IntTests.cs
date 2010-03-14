using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace Helpers.Net.Extensions.Tests
{
    public class IntTests
    {

        #region Data

        public static IEnumerable<object[]> EvenNumbers
        {
            get
            {
                yield return new object[] { 0 };
                yield return new object[] { 2 };
                yield return new object[] { 4 };
            }
        }

        public static IEnumerable<object[]> OddNumbers
        {
            get
            {
                yield return new object[] { 1 };
                yield return new object[] { 3 };
                yield return new object[] { 5 };
            }
        }

        #endregion


        #region Tests

        [Theory]
        [PropertyData("EvenNumbers")]
        public void IsEven_True(int i)
        {
            Assert.True(i.IsEven());
        }

        [Theory]
        [PropertyData("OddNumbers")]
        public void IsEven_False(int i)
        {
            Assert.False(i.IsEven());
        }

        [Theory]
        [PropertyData("OddNumbers")]
        public void IsOdd_True(int i)
        {
            Assert.True(i.IsOdd());
        }

        [Theory]
        [PropertyData("EvenNumbers")]
        public void IsOdd_False(int i)
        {
            Assert.False(i.IsOdd());
        }

        #endregion

    }
}
