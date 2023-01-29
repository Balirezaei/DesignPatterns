namespace CompositePattern.CompositeSpecification
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _targetSpecification;

        public NotSpecification(ISpecification<T> targetSpecification)
        {
            _targetSpecification = targetSpecification;
        }

        public bool IsSatisfiedBy(T item)
        {
            return !_targetSpecification.IsSatisfiedBy(item);
        }
    }
}
