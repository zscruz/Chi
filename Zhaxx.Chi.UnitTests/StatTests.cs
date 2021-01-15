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

        [Theory]
        [InlineData(new double[] { 1.0, 1.0}, 1.0)]
        [InlineData(new double[] { -1.0, -1.0, 1.0, 1.0}, -1.0)]
        [InlineData(new double[] { 3.0, 2.0, 1.0, 4.0, 1.0}, 1.0)]
        public void Mode_WhenCollectionHasManyElements(double[] testData, double expectedMode)
        {
            var actualMode = Stat.Mode(testData);

            Assert.Equal(expectedMode, actualMode);
        }

        [Fact]
        public void PopulationVariance_WhenCollectionIsNull_ShouldReturnNull()
        {
            var variance = Stat.PopulationVariance(null);

            Assert.Null(variance);
        }

        [Fact]
        public void PopulationVariance_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            double? variance = Stat.PopulationVariance(emptyList);

            Assert.Null(variance);
        }

        [Theory]
        [InlineData(new double[] { -1.0 })]
        [InlineData(new double[] { 0.0 })]
        [InlineData(new double[] { 1.0 })]
        [InlineData(new double[] { 5.1234 })]
        [InlineData(new double[] { 42.0 })]
        public void PopulationVariance_WhenCollectionHasLessThan2Elements_ShouldReturnNull(double[] testData)
        {
            var variance = Stat.PopulationVariance(testData);

            Assert.Null(variance);
        }

        [Theory]
        [InlineData(new double[] { 1.0, 1.0 }, 0)]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0}, 2.0)]
        public void PopulationVariance_WhenCollectionHasManyElements(double[] testData, double expectedVariance)
        {
            var actualVariance = Stat.PopulationVariance(testData);

            Assert.Equal(expectedVariance, actualVariance);
        }

        [Fact]
        public void PopulationStandardDeviation_WhenCollectionIsNull_ShouldReturnNull()
        {
            var standardDeviation = Stat.PopulationStandardDeviation(null);

            Assert.Null(standardDeviation);
        }

        [Fact]
        public void PopulationStandardDeviation_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            double? standardDeviation = Stat.PopulationStandardDeviation(emptyList);

            Assert.Null(standardDeviation);
        }

        [Theory]
        [InlineData(new double[] { -1.0 })]
        [InlineData(new double[] { 0.0 })]
        [InlineData(new double[] { 1.0 })]
        [InlineData(new double[] { 5.1234 })]
        [InlineData(new double[] { 42.0 })]
        public void PopulationStandardDeviation_WhenCollectionHasLessThan2Elements_ShouldReturnNull(double[] testData)
        {
            var standardDeviation = Stat.PopulationStandardDeviation(testData);

            Assert.Null(standardDeviation);
        }


        [Theory]
        [InlineData(new double[] { 1.0, 1.0 }, 0)]
        [InlineData(new double[] { 1.0, 1.0, 1.0, 1.0, 1.0 }, 0)]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 1.414)]
        [InlineData(new double[] { -1.0, 2.0, -3.0, 4.0, -5.0 }, 3.262)]
        public void PopulationStandardDeviation_WhenCollectionHasManyElements(double[] testData, double expectedDeviation)
        {
            var actualDeviation = Stat.PopulationStandardDeviation(testData).Value;

            Assert.Equal(expectedDeviation, actualDeviation, 3);
        }

        [Fact]
        public void SampleVariance_WhenCollectionIsNull_ShouldReturnNull()
        {
            var variance = Stat.SampleVariance(null);

            Assert.Null(variance);
        }

        [Fact]
        public void SampleVariance_WhenCollectionIsEmpty_ShouldReturnNull()
        {
            var emptyList = new List<double>();

            double? variance = Stat.SampleVariance(emptyList);

            Assert.Null(variance);
        }

        [Theory]
        [InlineData(new double[] { -1.0 })]
        [InlineData(new double[] { 0.0 })]
        [InlineData(new double[] { 1.0 })]
        [InlineData(new double[] { 5.1234 })]
        [InlineData(new double[] { 42.0 })]
        public void SampleVariance_WhenCollectionHasLessThan2Elements_ShouldReturnNull(double[] testData)
        {
            var variance = Stat.SampleVariance(testData);

            Assert.Null(variance);
        }

        [Theory]
        [InlineData(new double[] { 1.0, 1.0 }, 0)]
        [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, 2.5)]
        public void SampleVariance_WhenCollectionHasManyElements(double[] testData, double expectedVariance)
        {
            var actualVariance = Stat.SampleVariance(testData);

            Assert.Equal(expectedVariance, actualVariance);
        }
    }
}
