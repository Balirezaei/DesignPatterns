namespace CompositePattern.CompositeSpecification
{
    public class PositiveNum : CompositSpecification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity > 0 ;
        }
    }
}
