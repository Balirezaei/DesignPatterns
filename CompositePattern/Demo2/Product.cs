using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Demo2
{
    public abstract class Product//component
    {
        public abstract long Price();
    }

    public class Pacakage : Product//composit
    {
        private List<Product> _parts;

        public Pacakage(List<Product> parts)
        {
            _parts = parts;
        }

        public override long Price()
        {
            return _parts.Sum(m => m.Price());
        }
    }

    public class SpecificProduct : Product//leaf
    {
        public override long Price()
        {
            throw new NotImplementedException();
        }
    }
}
