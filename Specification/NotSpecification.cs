using System;

namespace Lsquared.Business.Specifications
{
    public class NotSpecification<T> : Specification<T>
    {
        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification ?? throw new ArgumentNullException(nameof(specification));
        }

        public override bool Match(T item) =>
            !_specification.Match(item);

        private readonly ISpecification<T> _specification;
    }
}
