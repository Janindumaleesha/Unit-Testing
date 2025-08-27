using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Services;

namespace UnitTestingDemo.Tests
{
    public class CalculatorServiceTestsUnit
    {
        [Fact]
        public void ShouldInputTwoIntAndAddThemReturnInt()
        {
            // Given
            var calService = new CalculatorService();

            int randomIntA = 8;
            int randomIntB = 7;
            int expectedValue = 15;


            // When
            var actualValue = calService.AddTwoNumbers(randomIntA, randomIntB);

            // Then
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void ShouldInputTwoDoubleAndAddThemReturnDouble()
        {
            // Given
            var calService = new CalculatorService();

            double randomDoubleA = 8.54;
            double randomDoubleB = 7.2;
            double expectedValue = 15.74;

            // When
            var actualVales = calService.AddTwoDoubles(randomDoubleA, randomDoubleB);

            // Then
            Assert.Equal(expectedValue, actualVales, 2);
        }

        [Fact]
        public void ShouldNotContainZero()
        {
            // Given
            var calService = new CalculatorService();


            // When
            var actualValue = calService.GetListOfNumbers();


            // Then
            //Assert.All(actualValue, n => Assert.NotEqual(0, n));
            Assert.DoesNotContain(0, actualValue);

        }

        [Fact]
        public void ShouldBeContain87()
        {
            // Given
            var calService = new CalculatorService();
            int expectedValue = 87;

            // When
            var actualValue = calService.GetListOfNumbers();

            // Then
            Assert.Contains(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(4, false)]
        [InlineData(100, false)]
        [InlineData(77, true)]
        public void ShouldTestForOddOrEvenNumber(int value, bool expectedValue)
        {
            // Given
            var calService = new CalculatorService();

            // When
            var actualValue = calService.IsOddNumber(value);

            // Then
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
