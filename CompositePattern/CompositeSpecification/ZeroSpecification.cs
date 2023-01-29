namespace CompositePattern.CompositeSpecification
{
    public class ZeroSpecification : CompositSpecification<long> //ISpecification<long>
    {
        public override bool IsSatisfiedBy(long entity)
        {
            return entity == 0;
        }
    }
}
