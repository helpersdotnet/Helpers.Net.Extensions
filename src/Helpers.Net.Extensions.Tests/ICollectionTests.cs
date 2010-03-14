using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace Helpers.Net.Extensions.Tests
{
    public class ICollectionTests
    {
        [Theory]
        [PropertyData("EmptyICollection")]
        [PropertyData("NullICollection")]
        public void IsNullOrEmpty_True(ICollection iCollection)
        {
            Assert.True(iCollection.IsNullOrEmpty());
        }

        [Theory]
        [PropertyData("ICollectionNotEmptyOrNull")]
        public void IsNullOrEmpty_False(ICollection iCollection)
        {
            Assert.False(iCollection.IsNullOrEmpty());
        }

        [Theory]
        [PropertyData("EmptyICollectionT")]
        [PropertyData("NullICollectionT")]
        public void IsNullOrEmptyT_True(ICollection<string> iCollectionT)
        {
            Assert.True(iCollectionT.IsNullOrEmpty());
        }

        [Theory]
        [PropertyData("ICollectionTNotEmptyOrNull")]
        public void IsNullOrEmptyT_False(ICollection<string> iCollectionT)
        {
            Assert.False(iCollectionT.IsNullOrEmpty());
        }

        #region Data

        public static IEnumerable<object[]> EmptyICollection
        {
            get
            {
                yield return new object[] { new List<string>() };
            }
        }

        public static IEnumerable<object[]> NullICollection
        {
            get
            {
                List<string> list = null;
                yield return new object[] { list };
            }
        }

        public static IEnumerable<object[]> ICollectionNotEmptyOrNull
        {
            get
            {
                yield return new object[] { new List<string> { "A" } };
                yield return new object[] { new List<string> { "A", "B" } };
            }
        }

        public static IEnumerable<object[]> EmptyICollectionT
        {
            get
            {
                yield return new object[] { new List<string>() };
            }
        }

        public static IEnumerable<object[]> NullICollectionT
        {
            get
            {
                List<string> list = null;
                yield return new object[] { list };
            }
        }

        public static IEnumerable<object[]> ICollectionTNotEmptyOrNull
        {
            get
            {
                yield return new object[] { new List<string> { "A" } };
                yield return new object[] { new List<string> { "A", "B" } };
            }
        }

        #endregion

    }
}
