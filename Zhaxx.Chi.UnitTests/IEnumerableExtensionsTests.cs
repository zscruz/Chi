using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Zhaxx.Chi.UnitTests
{
    public class IEnumerableExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_WhenCollectionIsNull_ReturnsTrue()
        {
            IEnumerable<int> list = null;

            bool actual = list.IsNullOrEmpty();

            Assert.True(actual);
        }

        [Fact]
        public void IsNullOrEmpty_WhenCollectionIsEmpty_ReturnsTrue()
        {
            IEnumerable<int> list = new List<int>();

            bool actual = list.IsNullOrEmpty();

            Assert.True(actual);
        }

        [Fact]
        public void IsNullOrEmpty_WhenCollectionContainsElements_ReturnsFalse()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4, 5 };

            bool actual = list.IsNullOrEmpty();

            Assert.False(actual);
        }

        [Fact]
        public void IsNullOrLessThanTwo_WhenCollectionIsNull_ReturnsTrue()
        {
            IEnumerable<int> list = null;

            bool actual = list.IsNullOrEmpty();

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new double[] { })]
        [InlineData(new double[] { 1.0 })]
        public void IsNullOrLessThan2_WhenCollectionHasLessThan2Elements_ReturnsTrue(double[] testData)
        {
            bool actual = testData.IsNullOrLessThanTwo();

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new double[] { 1.0, 2.0 })]
        [InlineData(new double[] { 1.0, 2.0, 3.0 })]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 })]
        public void IsNullOrLessThan2_WhenCollectionHas2OrMoreElements_ReturnsFalse(double[] testData)
        {
            bool actual = testData.IsNullOrLessThanTwo();

            Assert.False(actual);
        }
    }
}
