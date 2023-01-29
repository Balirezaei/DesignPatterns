using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.CompositeSpecification
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T item);
    }

    public abstract class CompositSpecification<T> : ISpecification<T>
    {
        public CompositSpecification<T> And(ISpecification<T> right)
        {
            return new AndSpecification<T>(this, right);
        }
        public CompositSpecification<T> Or(ISpecification<T> right)
        {
            return new ORSpecification<T>(this, right);
        }
        public abstract bool IsSatisfiedBy(T item);
    }
}
