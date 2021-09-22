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
    }
}
