namespace BuilderPattern
{
    public class UrlBuilder
    {
        private string _host;
        private string _port;
        private string _scheme = "http";
        private QueryStringBuilder _queryStringBuilder;

        public UrlBuilder WithHost(string host)
        {
            this._host = host;
            return this;
        }

        public UrlBuilder Withscheme(string scheme)
        {
            this._scheme = scheme;
            return this;
        }

        public UrlBuilder WithPort(string port)
        {
            this._port = $":{port}";
            return this;
        }

        public UrlBuilder WithQueryStringBuilder(QueryStringBuilder queryStringBuilder)
        {
            this._queryStringBuilder = queryStringBuilder;
            return this;
        }

        public UrlBuilder WithDelegateQueryStringBuilder(Action<QueryStringBuilder> queryStringBuilder)
        {
            this._queryStringBuilder = new QueryStringBuilder();
            queryStringBuilder.Invoke(_queryStringBuilder);
            return this;
        }

        public string Build()
        {
            var queryParam = this._queryStringBuilder?.Build();
            return $"{_scheme}://{_host}{_port}{queryParam}//";
        }


    }
}