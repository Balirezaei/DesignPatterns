namespace VisitorPattern
{
    /// <summary>
    /// Composite
    /// </summary>
    public abstract class FileSystemItem //component
    {
        public abstract long Size();

        public abstract void Accept(IFileSystemVisitor visitor);
    }

    public class Directory : FileSystemItem//composite
    {
        private List<FileSystemItem> _children;

        public Directory(params FileSystemItem[] children)
        {
            _children = children.ToList();
        }

        public override void Accept(IFileSystemVisitor visitor)
        {
            visitor.Visit(this);
            foreach (FileSystemItem child in _children)
            {
                //visitor.Visit(child as dynamic);
                child.Accept(visitor);
            }
     
        }

        public override long Size()
        {
            long sum = 0;
            foreach (var item in _children)
            {
                sum+=item.Size();
            }
            return sum;
        }
    }

    public class File : FileSystemItem//Leaf
    {
        private readonly long _size;

        public File(long size)
        {
            _size = size;
        }

        public override void Accept(IFileSystemVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override long Size()
        {
            return _size;
        }
    }
}