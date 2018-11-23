namespace Lsquared.Business.Specifications
{
    public class EmptySpecification<T> : Specification<T>
    {
        internal EmptySpecification() { }

        public override bool Match(T item) => true;
    }
}
