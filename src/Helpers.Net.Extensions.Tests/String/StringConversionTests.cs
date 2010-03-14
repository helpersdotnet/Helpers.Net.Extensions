using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace Helpers.Net.Extensions.Tests.String
{
    public class StringConversionTests
    {
        [Theory]
        [InlineData(1.0f, "1.0")]
        public void ToFloatTest(float expected, string strFloat)
        {
            Assert.Equal(expected, strFloat.ToFloat());
        }

        [Theory]
        [InlineData(1, "1")]
        public void ToIntTest(int expected, string strInt)
        {
            Assert.Equal(expected, strInt.ToInt());
        }

        [Theory]
        [InlineData(1.0, "1.0")]
        public void ToDoubleTest(double expected, string strDouble)
        {
            Assert.Equal(expected, strDouble.ToDouble());
        }

        public static IEnumerable<object[]> DecimalData
        {
            get
            {
                yield return new object[] { 1.0M, "1.0" };
            }
        }

        [Theory]
        [PropertyData("DecimalData")]
        public void ToDecimalTest(decimal expected, string strDecimal)
        {
            Assert.Equal(expected, strDecimal.ToDecimal());
        }

        [Theory]
        [InlineData('a', "a")]
        public void ToCharTest(char expected, string strChar)
        {
            Assert.Equal(expected, strChar.ToChar());
        }
    }
}
