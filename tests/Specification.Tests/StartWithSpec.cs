using Lsquared.Business.Specifications;

namespace Lsquared.Business.Specifications.Tests
{
    internal sealed class StartWithSpec : Specification<string>
    {
        public StartWithSpec(string prefix)
        {
            _prefix = prefix;
        }

        public override bool Match(string item) => item.StartsWith(_prefix);

        private readonly string _prefix;
    }
}
