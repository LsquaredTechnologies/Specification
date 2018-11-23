using Xunit;

namespace Lsquared.Business.Specifications.Tests
{
    public class NotSpecificationTests
    {
        [Fact]
        public void Match()
        {
            // Arrange
            var spec = !Specification.None<string>();

            // Act
            var actual = spec.Match("hello");

            // Assert
            Assert.True(actual);
        }
    }
}
