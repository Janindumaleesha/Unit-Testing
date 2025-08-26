using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestDemo.Services;

namespace UnitTestingDemo.Tests
{
    public class StudentServiceTestsUnit
    {
        [Fact]
        public void ShouldReturnFullNameByGettingFirstNameAndLastName()
        {
            // Given
            var studentService = new StudentService();
            string randomStringA = "Janindu";
            string randomStringB = "Maleesha";
            string expectedValue = "Janindu Maleesha";

            // When
            string actualValue = studentService.GetFullName(randomStringA, randomStringB);

            // Then
            //Assert.Equal(expectedValue, actualValue);
            //Assert.Equal(expectedValue, actualValue, ignoreCase: true);
            //Assert.Contains(expectedValue, actualValue, StringComparison.CurrentCultureIgnoreCase);
            Assert.Matches(new Regex("^[A-Za-z]+( [A-Za-z]+)*$"), actualValue);
        }
    }
}
