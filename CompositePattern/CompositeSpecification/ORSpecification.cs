namespace CompositePattern.CompositeSpecification
{
    public class ORSpecification<T> : CompositSpecification<T> //ISpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public ORSpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification)
        {
            _rightSpecification = rightSpecification;
            _leftSpecification = leftSpecification;
        }

        public override bool IsSatisfiedBy(T item)
        {
            return _leftSpecification.IsSatisfiedBy(item)
                 || _rightSpecification.IsSatisfiedBy(item);
        }
    }
}
