using System.Text;

namespace CompositePattern
{
    public interface IVisitor
    {
        void Visit(Box item);
        void Visit(Shelf item);
    }
    public class GraphDrawer : IVisitor
    {
        private StringBuilder _graph = new StringBuilder();


        public void Visit(Box item)
        {
            _graph.AppendLine($"Box cap: {item.TotlaCapacity()}");

        }

        public void Visit(Shelf item)
        {
            _graph.AppendLine($"Shelf cap: {item.TotlaCapacity()}");
            foreach (var c in item.InnerContainers)
            {
                c.Accept(this);
            }
        }
        public string GetGraph() => _graph.ToString();
    }

}
