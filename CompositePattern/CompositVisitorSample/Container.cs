using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Container
    {
        public IReadOnlyList<Item> Items;
        public abstract int TotlaCapacity();
        public int RemainCapacity()
        {
            return TotlaCapacity() - Items.Sum(m => m.Size);
        }
        public abstract void Accept(IVisitor visitor);

    }

    public class Box : Container
    {
        private int capacity;
        private List<Item> items;
        public Box(int capacity)
        {
            items = new List<Item>();
            this.capacity = capacity;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override int TotlaCapacity() => capacity;

    }
    public class Shelf : Container
    {
        private List<Container> _innerContainer;
        public IReadOnlyList<Container> InnerContainers => _innerContainer.AsReadOnly();

        public Shelf()
        {
            _innerContainer = new List<Container>();
        }

        public override int TotlaCapacity()
        {
            return _innerContainer.Sum(m => m.TotlaCapacity());
        }
        public void AddContainers(params Container[] container)
        {
            _innerContainer.AddRange(container);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Item
    {
        public int Size { get; set; }

        public Item(int size)
        {
            Size = size;
        }
    }

}
