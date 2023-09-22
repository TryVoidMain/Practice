using Algorithms.NumericalAlgorithms;

namespace Algorithms.Tests.NumericalAlgorithms
{
    public class FastPowTest
    {
        [Fact]
        public void FindFastPow_Success()
        {
            // Arrange
            var res_100 = 100;
            var res_4 = 4;
            var res_49_negativeInput = 49;
            var res_1_000_000_000_000_000_000 = 1_000_000_000_000_000_000;

            // Act
            // Assert
            Assert.Equal(res_100, FastPow.FindFastPow(10, 2));
            Assert.Equal(res_4, FastPow.FindFastPow(2, 2));
            Assert.Equal(res_49_negativeInput, FastPow.FindFastPow(-7, 2));
            Assert.Equal(res_1_000_000_000_000_000_000, FastPow.FindFastPow(10, 18));
        }

        [Fact]
        public void FindFastPow_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => FastPow.FindFastPow(10, 40));
            Assert.Throws<ArgumentOutOfRangeException>(() => FastPow.FindFastPow(10, 39));
        }
    }
}
