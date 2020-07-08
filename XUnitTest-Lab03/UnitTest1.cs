using System;
using Xunit;
using static Lab03_ReviewOfCSharp.Program;

namespace XUnitTest_Lab03
{
    public class UnitTest1
    {
        [Fact]
        public void IsTheInputNumberGreaterThanZero()
        {
            // Arrange
            int input = 10;

            // Act
            int outPutFromMethod = FindAverageNumber(input);

            // Assert
            Assert.Equal(5, outPutFromMethod);
        }

    }
}
