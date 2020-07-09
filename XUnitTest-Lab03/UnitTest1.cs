using System;
using Xunit;
using static Lab03_ReviewOfCSharp.Program;

namespace XUnitTest_Lab03
{
    public class UnitTest1
    {

        [Fact]
        public void CanGetAverages()
        {
            // Arrange
            int[] numbers = { 2, 3, 4 };

            // Act
            double value = FindAverageNumber(numbers);

            // Assert
            Assert.Equal(3, value);
        }

        [Fact]
        public void AreAllNumbersZero()
        {
            // Arrange
            int[] numbers = { 0, 0, 0, 0 };

            // Act
            double value = FindAverageNumber(numbers);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void CanInputArrayBeZero()
        {
            // Arrange
            int[] numbers = {};

            // Act
            double value = FindAverageNumber(numbers);

            // Assert
            Assert.Equal(0, value);
        }

    }
}
