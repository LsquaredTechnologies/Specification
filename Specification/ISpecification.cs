namespace Lsquared.Business.Specifications
{
    public interface ISpecification<in T>
    {
        bool Match(T item);
    }
}
