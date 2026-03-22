namespace Udemy.Api.Hypermedia
{
    public abstract class ContentResponseEnricher<T> : IResponseEnricher where T : ISupportsHyperMedia
    {
        public ContentResponseEnricher()
        {

        }
        public virtual bool CanEnrich(Type contentType)
        {
            return contentType == typeof(T) || contentType == typeof(List<T>) || contentType == typeof(PagedSearchVO<T>);
        }

        protected abstract Task EnrichModel(T content, IUrlHelper urlHelper);

        bool IResponseEnricher.CanEnrich(ResultExecutingContext response)
        {
            if (response.Result is OkObjectResult { Value: not null } okObjectResult)
            {
                return CanEnrich(okObjectResult.Value.GetType());
            }

            return false;
        }
        public async Task Enrich(ResultExecutingContext response)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(response);

            if (response.Result is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value is T model)
                {
                    await EnrichModel(model, urlHelper);
                }
                else if (okObjectResult.Value is List<T> collection)
                {
                    ConcurrentBag<T> bag = new(collection);
                    await Task.WhenAll(bag.Select(element => EnrichModel(element, urlHelper)));
                }
                else if (okObjectResult.Value is PagedSearchVO<T> pagedSearch)
                {
                    await Task.WhenAll(pagedSearch.List.Select(element => EnrichModel(element, urlHelper)));
                }
            }
        }
    }
}
