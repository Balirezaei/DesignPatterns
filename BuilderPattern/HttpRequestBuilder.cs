namespace BuilderPattern
{

    public interface IHttpRequestBuilder
    {
        IHttpRequestBuilder WithUrl(string url);
        HttpRequestMessage Build();
    }
    public interface IHttpRequestMethodBuilder { 
        IHttpRequestContentBuilder Post();
        IHttpRequestContentBuilder Put();
        IHttpRequestBuilder Get();
    }

    public interface IHttpRequestContentBuilder {
        IHttpRequestBuilder WithBody(string v);

    }

    public class HttpRequestBuilder : IHttpRequestBuilder, IHttpRequestMethodBuilder, IHttpRequestContentBuilder
    {
        public HttpRequestBuilder()
        {
        }
        public static IHttpRequestMethodBuilder NewInstanse()
        {
            return new HttpRequestBuilder();
        }
        public IHttpRequestBuilder WithBody(string v)
        {
            return this;
        }

        public IHttpRequestContentBuilder Post()
        {
            return this;
        }
        public IHttpRequestBuilder Get()
        {
            return this;
        }
        public IHttpRequestContentBuilder Put()
        {
            return this;
        }


        public HttpRequestMessage Build()
        {
            throw new NotImplementedException();
        }

        public IHttpRequestBuilder WithUrl(string url)
        {
            return this;
        }
    }
}