using Behm.Extensions.Strings;
using FluentAssertions;
using Xunit;

namespace Behm.Extension.Strings.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void StringEmpty_EqualsEmptyDoubleQuotes()
        {
            // Arrange
            var testEmptyString = string.Empty;
            var testDoubleQuoteEmptyString = "";

            // Act, Assert
            Assert.Equal(testEmptyString, testDoubleQuoteEmptyString);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData(" ", null)]
        [InlineData("   ", null)]
        [InlineData("some value", "some value")]
        public void GetNullIfEmpty_GivenValue_ReturnsExpectedResult(string testString, string expectedResult)
        {
            // Arrange

            // Act
            var result = testString.GetNullIfEmptyString();

            // Assert
            result.Should().Be(expectedResult);
        }


        [Theory]
        [InlineData(null, "")]
        [InlineData(" ", " ")]
        [InlineData("non-empty string", "non-empty string")]
        public void GetEmptyStringIfNull_GivenValue_ReturnsExpectedResult(string testString, string expectedResult)
        {
            // Arrange
            
            // Act
            var result = testString.GetEmptyStringIfNull();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("", "someDefaultValue", "someDefaultValue")]
        [InlineData(null, "someDefaultValue", "someDefaultValue")]
        [InlineData(" ", "someDefaultValue", " ")]
        [InlineData("testString", "someDefaultValue", "testString")]
        public void GetDefaultIfEmpty_GivenValue_ReturnsExpectedResult(string testString, string defaultValue, string expectedResult)
        {
            // Arrange

            // Act
            var result = testString.GetDefaultIfEmpty(defaultValue);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("testing123", false)]
        public void IsEmpty_GivenValue_ReturnsExpectedResult(string testString, bool expectedResult)
        {
            // Arrange

            // Act
            var result = testString.IsEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("123", true)]
        [InlineData("-7890", true)]
        [InlineData("2147483647", true)]
        [InlineData("-2147483648", true)]
        [InlineData("92147483647", false)]
        [InlineData("-92147483648", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("testing123", false)]
        [InlineData("789testing", false)]
        public void IsInteger_GivenValue_ReturnsExpectedResult(string testString, bool expectedResult)
        {
            // Arrange

            // Act
            var result = testString.IsInteger();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("123456.87", true)]
        [InlineData("123,456.87", true)]
        [InlineData("123,456.87654", true)]
        [InlineData("123", true)]
        [InlineData("-7890", true)]
        [InlineData("2147483647", true)]
        [InlineData("-2147483648", true)]
        [InlineData("92147483647", true)]
        [InlineData("-92147483648", true)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("testing123", false)]
        [InlineData("789testing", false)]
        public void IsNumeric_GivenValue_ReturnsExpectedResult(string testString, bool expectedResult)
        {
            // Arrange

            // Act
            var result = testString.IsNumeric();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("testing123", "321gnitset")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        public void Reverse_GivenValue_ReturnsExpectedResult(string testString, string expectedResult)
        {
            // Arrange

            // Act
            var result = testString.Reverse();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
