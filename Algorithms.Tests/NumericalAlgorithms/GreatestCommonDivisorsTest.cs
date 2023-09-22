using Algorithms.NumericalAlgorithms;

namespace Algorithms.Tests.NumericalAlgorithms
{
    public class GreatestCommonDivisorsTest
    {
        [Fact]
        public void FindGreatestCommonDivisors_Success()
        {
            // Arrange
            var res_100 = 100;
            var res_4 = 4;


            // Act
            // Assert

            Assert.Equal(res_100, GreatestCommonDivisors.FindGreatestCommonDivisors(1000, 1100));
            Assert.Equal(res_4, GreatestCommonDivisors.FindGreatestCommonDivisors(8, 20));
        }

        [Fact]
        public void FindGreatestCommonDivisors_Fail()
        {
            // Arrange
            var res_100 = 100;
            var res_4 = 4;

            // Act
            // Assert

            Assert.NotEqual(res_100, GreatestCommonDivisors.FindGreatestCommonDivisors(1000, 123514));
            Assert.NotEqual(res_4, GreatestCommonDivisors.FindGreatestCommonDivisors(8, 21));
        }
    }
}
