namespace BuilderPattern
{
    public class BuilderTests
    {
        [Fact]
        public void SimpleBuilder()
        {
            var expectedUrl = "https://google.com:8080//";
            var url=new UrlBuilder()
                .WithHost("google.com")
                .Withscheme("https")
                .WithPort("8080")
                .Build();
            Assert.Equal(expectedUrl, url);
        }

        [Fact]
        public void NestedBuilder()
        {
            var expectedUrl = "http://mysite.com?id=1//";
            var url = new UrlBuilder()
                .WithHost("mysite.com")
                .WithQueryStringBuilder(new QueryStringBuilder().WithParam("id","1"))
                .Build();
            Assert.Equal(expectedUrl, url);
        }


        [Fact]
        public void DelegateNestedBuilder()
        {
            var expectedUrl = "http://mysite.com?id=1//";
            var url = new UrlBuilder()
                .WithHost("mysite.com")
                .WithDelegateQueryStringBuilder(m=>m.WithParam("id", "1"))
                .Build();
            Assert.Equal(expectedUrl, url);
        }

        [Fact]
        public void StepBuilderTest()
        {
            var uri = HttpRequestBuilder
                .NewInstanse()
                .Post()
                .WithBody("")
                .WithUrl("")
                .Build();

            Assert.Equal("","");

        }

    }
}