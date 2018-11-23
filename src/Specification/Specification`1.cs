namespace Lsquared.Business.Specifications
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Specification<T> : ISpecification<T>
    {
        /// <summary>
        /// 
        /// </summary>
        protected Specification() { }

        /// <inheritdoc />
        public abstract bool Match(T item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Specification<T> operator &(Specification<T> left, Specification<T> right) =>
            new AndSpecification<T>(left, right);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Specification<T> operator |(Specification<T> left, Specification<T> right) =>
            new OrSpecification<T>(left, right);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        public static Specification<T> operator !(Specification<T> specification) =>
            new NotSpecification<T>(specification);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        public static bool operator true(Specification<T> specification) => true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        public static bool operator false(Specification<T> specification) => false;
    }
}
