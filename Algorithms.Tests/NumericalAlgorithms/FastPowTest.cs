using Algorithms.NumericalAlgorithms;

namespace Algorithms.Tests.NumericalAlgorithms
{
    public class FastPowTest
    {
        [Fact]
        public void FindFastPow_Success()
        {
            // Arrange
            var powClass = new FastPow();

            // Act
            var res_100 = powClass.FindFastPow(10, 2);
            var res_4 = powClass.FindFastPow(2, 2);
            var res_49_negativeInput = powClass.FindFastPow(-7, 2);

            // Assert
            Assert.Equal(100, res_100);
            Assert.Equal(4, res_4);
            Assert.Equal(49, res_49_negativeInput);
        }
    }
}
