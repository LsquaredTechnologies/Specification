namespace Lsquared.Business.Specifications
{
/// <summary>
/// 
/// </summary>
    public static class Specification
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="specifications"></param>
        /// <returns></returns>
        public static Specification<T> And<T>(params ISpecification<T>[] specifications) =>
            new AndSpecification<T>(specifications);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="specifications"></param>
        /// <returns></returns>
        public static Specification<T> Or<T>(params ISpecification<T>[] specifications) => 
            new OrSpecification<T>(specifications);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="specification"></param>
        /// <returns></returns>
        public static Specification<T> Not<T>(ISpecification<T> specification) =>
            new NotSpecification<T>(specification);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Specification<T> Empty<T>() => new EmptySpecification<T>();
    }
}
