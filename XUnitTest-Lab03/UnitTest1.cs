using System;
using Xunit;
using static Lab03_ReviewOfCSharp.Program;

namespace XUnitTest_Lab03
{
    public class UnitTest1
    {

        [Fact]
        public void CanReturnZeroWhenLengthIsLessThanThree()
        {
            // Arrange
            string input = "2 3";

            // Act
            int outPutFromMethod = MultiplyInputNumber(input);

            // Assert
            Assert.Equal(0, outPutFromMethod);
        }

        [Fact]
        public void CanReturnProductWithThreeNumbers()
        {
            // Arrange
            string numbers = "2 3 4";

            // Act
            int output = MultiplyInputNumber(numbers);

            // Assert
            Assert.Equal(24, output);
        }


        [Theory]
        [InlineData("4 8 15 16", 480)]
        [InlineData("1 1 1", 1)]
        [InlineData("cat dog 5", 5)]
        [InlineData("candycane chocolate", 0)]
        [InlineData("-5 -5 1", 25)]
        public void CanReturnProperProduct(string numbers, int product)
        {
            // Arrange & Act
            int result = MultiplyInputNumber(numbers);

            // Assert
            Assert.Equal(product, result);
        }

        [Fact]
        public void CanGetAverages()
        {
            // Arrange
            int[] numbers = { 2, 3, 4 };

            // Act
            double value = CalculateAverageNumber(numbers);

            // Assert
            Assert.Equal(3, value);
        }

        [Fact]
        public void AreAllNumbersZero()
        {
            // Arrange
            int[] numbers = { 0, 0, 0, 0 };

            // Act
            double value = CalculateAverageNumber(numbers);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void CanInputArrayBeZero()
        {
            // Arrange
            int[] numbers = { };

            // Act
            double value = CalculateAverageNumber(numbers);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void CanReturnAverageForDifferentNumbers()
        {
            // Arrange
            int[] numbers = { 24, 6, 87, 9 };

            // Act
            double value = CalculateAverageNumber(numbers);

            // Assert
            Assert.Equal(31, value);
        }

    }
}
