using CompositePattern.CompositeSpecification;
using FluentAssertions;

namespace CompositePattern
{
    public class SpecificationUnitTest
    {
        [Fact]
        public void Test1()
        {
            var and = GetSpecification();

            and.IsSatisfiedBy(10).Should().Be(true);
        }

        private static ISpecification<long> GetSpecification()
        {
            //return new PositiveNum();
            //var positiveEvenNumber = new AndSpecification<long>(new EvenNum(), new PositiveNum());
            //with composite specificatio

            //var zero = new ZeroSpecification();
            //return new ORSpecification<long>(zero, positiveEvenNumber);

            return new EvenNum().And(new PositiveNum()).Or(new ZeroSpecification());
        }

    }
}