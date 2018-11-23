using System.Collections.Generic;

namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public IReadOnlyCollection<ISpecification<T>> Specifications { get => _specifications; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specifications"></param>
        protected CompositeSpecification(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications is HashSet<ISpecification<T>> set ? set : new HashSet<ISpecification<T>>(specifications);
        }

        private readonly HashSet<ISpecification<T>> _specifications;
    }
}
