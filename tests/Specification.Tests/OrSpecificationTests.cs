
using Xunit;

namespace Lsquared.Business.Specifications.Tests
{
    public class OrSpecificationTests
    {
        [Theory]
        [InlineData("", false)]
        [InlineData("Foo", true)]
        [InlineData("FooBar", true)]
        [InlineData("Bar", true)]
        [InlineData("Wizz", false)]
        public void Match(string input, bool expected)
        {
            // Arrange
            var spec = new StartWithSpec("Bar") | new StartWithSpec("Foo");

            // Act
            var actual = spec.Match(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
