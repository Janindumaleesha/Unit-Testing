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
    }
}
