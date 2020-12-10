using System;
using System.Collections.Generic;
using Xunit;

namespace Zhaxx.Chi.UnitTests
{
    public class StatTests
    {
        [Fact]
        public void Mean_WhenCollectionIsNull_ShouldReturnNull()
        {
            var mean = Stat.Mean(null);

            Assert.Null(mean);
        }

        [Fact]
        public void Mean_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            var mean = Stat.Mean(emptyList);

            Assert.Null(mean);
        }
        
        [Theory]
        [InlineData(new double[] { -1.0 }, -1.0)]
        [InlineData(new double[] { 0.0 }, 0.0)]
        [InlineData(new double[] { 1.0 }, 1.0)]
        [InlineData(new double[] { 5.1234 }, 5.1234)]
        [InlineData(new double[] { 42.0 }, 42.0)]
        public void Mean_WhenCollectionHasOnlyOneElement(double[] testData, double expectedMean)
        {
            var actualMean = Stat.Mean(testData);

            Assert.Equal(expectedMean, actualMean);
        }

        [Theory]
        [InlineData(new double[] { 0.0, 0.0, 0.0 }, 0.0)]
        [InlineData(new double[] { 1.0, 1.0, 1.0, 1.0, 1.0 }, 1.0)]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
        public void Mean_WhenCollectionContainsManyElements(double[] testData, double expectedMean)
        {
            var actualMean = Stat.Mean(testData);

            Assert.Equal(expectedMean, actualMean);
        }
    }
}
