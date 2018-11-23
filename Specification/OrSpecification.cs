using System.Linq;

namespace Lsquared.Business.Specifications
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        internal OrSpecification(params ISpecification<T>[] specifications) : base(specifications) { }

        public override bool Match(T item) => Specifications.Any((s) => s.Match(item));
    }
}
