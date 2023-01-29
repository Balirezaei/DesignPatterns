namespace VisitorPattern
{
    public partial class VisitorUnitTest
    {
        [Fact]
        public void LargestFileVisitorTest()
        {
            //صورت مسیله چه تعداد فایل از یک گیگ بیشتره
            // حل مسیله با ویزیتور
            var file1 = new File(1000);
            var file2 = new File(2000);
            var file3 = new File(3000);

            var innerDirectory = new Directory(file2, file3);

            var root = new Directory(file1, innerDirectory);

            var visitor = new LargestFileVisitor();

            root.Accept(visitor);

            Assert.Equal(3000, visitor._maxSize);

        }
        [Fact]
        public void CountingVisitorFileTest()
        {
            var file1 = new File(1000);
            var file2 = new File(2000);
            var file3 = new File(3000);

            var innerDirectory = new Directory(file2, file3);

            var root = new Directory(file1, innerDirectory);

            var visitor = new CountingVisitor();

            root.Accept(visitor);

            Assert.Equal(3, visitor.FileCount);

        }
        


    }
}