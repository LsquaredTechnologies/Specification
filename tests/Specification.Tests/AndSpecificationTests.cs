
using Xunit;

namespace Lsquared.Business.Specifications.Tests
{
    public class AndSpecificationTests
    {
        [Theory]
        [InlineData("Foo", true)]
        [InlineData("FooBar", true)]
        [InlineData("Bar", false)]
        public void Match(string input, bool expected)
        {
            // Arrange
            var spec = new IsNotEmptySpec() & new StartWithSpec("Foo");

            // Act
            var actual = spec.Match(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
