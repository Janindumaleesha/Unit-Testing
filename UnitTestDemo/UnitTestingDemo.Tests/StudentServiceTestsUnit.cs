using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        [Fact]
        public void ShouldFullNAmeBeNotNull()
        {
            // Given
            var studentService = new StudentService();
            string randomStringA = "Janindu";
            string randomStringB = "Maleesha";

            // When
            string actualValue = studentService.GetFullName(randomStringA, randomStringB);

            // Then
            Assert.NotNull(actualValue);
        }

        [Fact]
        public void ShouldPassTheExamWithPassMark()
        {
            // Given
            var studentService = new StudentService();
            int randomMarkA = 77;
            //bool expectedValue = true;

            // When
            var actualValue = studentService.IsPassedTheExam(randomMarkA);

            // Then
            //Assert.True(expectedValue = actualValue);
            Assert.True(actualValue);
        }

        [Fact]
        public void ShouldFailTheExamWithFailMark()
        {
            // Given
            var studentService = new StudentService();
            int randomMarkB = 45;
            //bool expectedValue = false;

            // When
            var actualValue = studentService.IsPassedTheExam(randomMarkB);

            // Then
            //Assert.False(expectedValue = actualValue);
            Assert.False(actualValue);
        }

        [Fact]
        public void EmailShouldNotBeNullOrEmpty()
        {
            // Given
            var studentService = new StudentService();
            string randomEmptyEmail = string.Empty;
            string expectedMessage = "Email Should Be Required";

            // When


            // Then
            var exceptionDetails = Assert.Throws<ArgumentException>(() => studentService.GetStudentId(randomEmptyEmail));

            Assert.Equal(expectedMessage, exceptionDetails.Message);
        }
    }
}
