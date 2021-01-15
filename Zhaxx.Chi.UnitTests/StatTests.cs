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

        [Fact]
        public void Median_WhenCollectionIsNull_ShouldReturnNull()
        {
            var mean = Stat.Mean(null);

            Assert.Null(mean);
        }

        [Fact]
        public void Median_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            double? median = Stat.Mean(emptyList);

            Assert.Null(median);
        }

        [Theory]
        [InlineData(new double[] { -1.0 }, -1.0)]
        [InlineData(new double[] { 0.0 }, 0.0)]
        [InlineData(new double[] { 1.0 }, 1.0)]
        [InlineData(new double[] { 5.1234 }, 5.1234)]
        [InlineData(new double[] { 42.0 }, 42.0)]
        public void Median_WhenCollectionHasOnlyOneElement(double[] testData, double expectedMedian)
        {
            var actualMedian = Stat.Median(testData);

            Assert.Equal(expectedMedian, actualMedian);
        }

        [Theory]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 3.0)]
        [InlineData(new double[] { 3.0, 2.0, 5.0, 1.0, 4.0 }, 3.0)]
        public void Median_WhenCollectionContainsOddCountOfElements(double[] testData, double expectedMedian)
        {
            var actualMedian = Stat.Median(testData);

            Assert.Equal(expectedMedian, actualMedian);
        }

        [Theory]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0 }, 2.5)]
        [InlineData(new double[] {  2.0, 2.0 }, 2.0)]
        public void Median_WhenCollectionContainsEvenCountOfElements(double[] testData, double expectedMedian)
        {
            var actualMedian = Stat.Median(testData);

            Assert.Equal(expectedMedian, actualMedian);
        }

        [Fact]
        public void Mode_WhenCollectionIsNull_ShouldReturnNull()
        {
            var mode = Stat.Mode(null);

            Assert.Null(mode);
        }

        [Fact]
        public void Mode_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            double? mode = Stat.Mode(emptyList);

            Assert.Null(mode);
        }


        [Theory]
        [InlineData(new double[] { 1.0, 1.0}, 1.0)]
        [InlineData(new double[] { -1.0, -1.0, 1.0, 1.0}, -1.0)]
        [InlineData(new double[] { 3.0, 2.0, 1.0, 4.0, 1.0}, 1.0)]
        public void Mode_WhenCollectionHasManyElements(double[] testData, double expectedMode)
        {
            var actualMode = Stat.Mode(testData);

            Assert.Equal(expectedMode, actualMode);
        }

        [Theory]
        [InlineData(new double[] { -1.0 }, -1.0)]
        [InlineData(new double[] { 0.0 }, 0.0)]
        [InlineData(new double[] { 1.0 }, 1.0)]
        [InlineData(new double[] { 5.1234 }, 5.1234)]
        [InlineData(new double[] { 42.0 }, 42.0)]
        public void Mode_WhenCollectionHasOnlyOneElement(double[] testData, double expectedMode)
        {
            var actualMode = Stat.Mode(testData);

            Assert.Equal(expectedMode, actualMode);
        }
    }
}
