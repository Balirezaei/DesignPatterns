namespace BuilderPattern
{
    public class QueryStringBuilder
    {
        private Dictionary<string, string> _queryParameters = new Dictionary<string, string>();
        public QueryStringBuilder WithParam(string key, string value)
        {
            _queryParameters.Add(key, value);
            return this;
        }
        public string Build()
        {
            string param=null;
            foreach (var item in _queryParameters)
            {
                param += $"{item.Key}={item.Value}";
            }
            return param!=null ? $"?{param}":"";
        }

    }
}