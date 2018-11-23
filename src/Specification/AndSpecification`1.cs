using System.Linq;

namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class AndSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="specifications"></param>
        internal AndSpecification(params ISpecification<T>[] specifications) : base(specifications) { }

        /// <inheritdoc />
        public override bool Match(T item) => Specifications.All((s) => s.Match(item));
    }
}
