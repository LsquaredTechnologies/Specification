namespace Lsquared.Business.Specifications
{
    public abstract class Specification<T> : ISpecification<T>
    {
        protected Specification() { }

        public abstract bool Match(T item);

        public static Specification<T> operator &(Specification<T> left, Specification<T> right) =>
            new AndSpecification<T>(left, right);

        public static Specification<T> operator |(Specification<T> left, Specification<T> right) =>
            new OrSpecification<T>(left, right);

        public static Specification<T> operator !(Specification<T> specification) =>
            new NotSpecification<T>(specification);

        public static bool operator true(Specification<T> specification) => true;

        public static bool operator false(Specification<T> specification) => false;
    }
}
