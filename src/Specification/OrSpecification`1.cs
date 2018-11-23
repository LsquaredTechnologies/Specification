using System.Linq;

namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class OrSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="specifications"></param>
        internal OrSpecification(params ISpecification<T>[] specifications) : base(specifications) { }

        /// <inheritdoc />
        public override bool Match(T item) => Specifications.Any((s) => s.Match(item));
    }
}
