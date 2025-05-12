using System;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Tanjameh.Core.Helper;



public record PagingRequest(int PageNumber, int PageSize = 30);

public record PagingResponse<T>(IReadOnlyCollection<T> Data, int PageNumber, int PageSize, int? TotalPages, int? TotalCount);


public record FilterRequest(string Predicate, params object?[] Args);


public class OrderRequest<TModel>
{
    public Expression<Func<TModel, object>>? OrderBy { get; init; } = null;

    public bool OrderByDescending { get; init; } = false;
}
