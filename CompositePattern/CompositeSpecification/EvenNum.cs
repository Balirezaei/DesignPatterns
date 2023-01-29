namespace CompositePattern.CompositeSpecification
{
    public class EvenNum : CompositSpecification<long>//ISpecification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity % 2 == 0;
        }
    }
}
