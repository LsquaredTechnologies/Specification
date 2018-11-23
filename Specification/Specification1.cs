namespace Lsquared.Business.Specifications
{
    public static class Specification
    {
        public static Specification<T> And<T>(params ISpecification<T>[] specifications) =>
            new AndSpecification<T>(specifications);

        public static Specification<T> Or<T>(params ISpecification<T>[] specifications)
            => new OrSpecification<T>(specifications);

        public static Specification<T> Not<T>(ISpecification<T> specification) =>
            new NotSpecification<T>(specification);

        public static Specification<T> Empty<T>() => new EmptySpecification<T>();
    }
}
