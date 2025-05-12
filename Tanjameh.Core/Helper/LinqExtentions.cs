

using Tanjameh.Core.Helper;



public static class Extentions
{

    public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, PagingRequest pagingRequest) where T : class
    {
        if (pagingRequest.PageNumber <= 0)
        {
            throw new ArgumentException("PageNumber must be greater than 0.", nameof(pagingRequest.PageNumber));
        }
        if (pagingRequest.PageSize <= 0)
        {
            throw new ArgumentException("PageSize must be greater than 0.", nameof(pagingRequest.PageSize));
        }

        return query.Skip((pagingRequest.PageNumber - 1) * pagingRequest.PageSize).Take(pagingRequest.PageSize);
    }
}

