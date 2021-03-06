namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class EmptySpecification<T> : Specification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        internal EmptySpecification() { }

        /// <inheritdoc />
        public override bool Match(T item) => true;
    }
}
