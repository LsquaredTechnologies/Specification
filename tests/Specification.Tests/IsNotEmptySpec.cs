using Lsquared.Business.Specifications;

namespace Lsquared.Business.Specifications.Tests
{
    internal sealed class IsNotEmptySpec : Specification<string>
    {
        public override bool Match(string item) => item.Length > 0;
    }
}
