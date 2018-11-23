using System;

namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class NotSpecification<T> : Specification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification ?? throw new ArgumentNullException(nameof(specification));
        }

        /// <inheritdoc />
        public override bool Match(T item) =>
            !_specification.Match(item);

        private readonly ISpecification<T> _specification;
    }
}
