using System.Collections.Generic;
using System.Drawing;
using Xunit;
using Xunit.Extensions;

namespace Helpers.Net.Extensions.Tests
{
    public class ColorTest
    {
        [Theory]
        [PropertyData("Colors_With_Hex")]
        public void ToHexStringTest(Color color, string hex)
        {
            Assert.Equal(color.ToHexString(), hex);
        }

        public static IEnumerable<object[]> Colors_With_Hex
        {
            get
            {
                yield return new object[] { Color.FromName("red"), "#FF0000" };
                // todo: add a bit more
            }
        }
    }
}
