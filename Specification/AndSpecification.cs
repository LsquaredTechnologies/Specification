using System.Linq;

namespace Lsquared.Business.Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        internal AndSpecification(params ISpecification<T>[] specifications) : base(specifications) { }

        public override bool Match(T item) => Specifications.All((s) => s.Match(item));
    }
}
