using Behm.Extensions.Strings;
using FluentAssertions;
using Xunit;

namespace Behm.Extension.Strings.Tests
{
    public class WordExtensionsTests
    {
        [Theory]
        [InlineData("What's up?", 2)]
        [InlineData("Bond, James Bond", 3)]
        [InlineData("This is a sentence.", 4)]
        [InlineData("This is a sentence?", 4)]
        [InlineData("This is a sentence!", 4)]
        [InlineData("Yes, this is a sentence.", 5)]
        public void WordCount_GivenString_ReturnsCorrectCount(string testString, int expectedWordCount)
        {
            // Arrange
            
            // Act
            var result = testString.WordCount();

            // Assert
            result.Should().Be(expectedWordCount);
        }
    }
}
