namespace CompositePattern.CompositeSpecification
{
    public class AndSpecification<T> : CompositSpecification<T>//: ISpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification)
        {
            _rightSpecification = rightSpecification;
            _leftSpecification = leftSpecification;
        }

        public override bool IsSatisfiedBy(T item)
        {
            return _leftSpecification.IsSatisfiedBy(item)
                 && _rightSpecification.IsSatisfiedBy(item);
        }
    }
}
