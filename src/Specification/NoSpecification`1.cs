namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class NoSpecification<T> : Specification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        internal NoSpecification() { }

        /// <inheritdoc />
        public override bool Match(T item) => false;
    }
}
