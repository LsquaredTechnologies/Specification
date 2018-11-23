using Xunit;

namespace Lsquared.Business.Specifications.Tests
{
    public class EmptySpecificationTests
    {
        [Fact]
        public void Match()
        {
            // Arrange
            var spec = Specification.Empty<string>();

            // Act
            var actual = spec.Match("hello");

            // Assert
            Assert.True( actual);
        }
    }
}
