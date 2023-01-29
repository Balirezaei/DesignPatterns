namespace VisitorPattern
{

    public interface IFileSystemVisitor
    {
        //المان های کانکریت به عنوان ورودی در نظر گرفته می شوند 
        public void Visit(Directory directory);
        public void Visit(File file);
    }

    public class LargestFileVisitor : IFileSystemVisitor
    {
        public long _maxSize = 0;
        public void Visit(Directory directory)
        {

        }

        public void Visit(File file)
        {
            if (file.Size() > _maxSize)
            {
                _maxSize = file.Size();
            }
        }

    }

    public class CountingVisitor: IFileSystemVisitor
    {
        public int DirectoryCount { get; private set; }
        public int FileCount { get; private set; }

        public void Visit(Directory directory)
        {
            DirectoryCount++;
        }

        public void Visit(File file)
        {
            FileCount++;
        }
    }

}