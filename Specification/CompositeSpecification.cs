using System.Collections.Generic;

namespace Lsquared.Business.Specifications
{
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        public IReadOnlyCollection<ISpecification<T>> Specifications { get => _specifications; }

        protected CompositeSpecification(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications is HashSet<ISpecification<T>> set ? set : new HashSet<ISpecification<T>>(specifications);
        }

        private readonly HashSet<ISpecification<T>> _specifications;
    }
}
