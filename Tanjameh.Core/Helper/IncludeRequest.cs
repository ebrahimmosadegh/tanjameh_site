using System.Linq.Expressions;

namespace Tanjameh.Core.Helper;

public class IncludeRequest<TEntity> where TEntity : class
{
    public IncludeRequest(Expression<Func<TEntity, bool>> includeExpression)
    {
        IncludeExpressions = [includeExpression];
    }

    public IncludeRequest(Expression<Func<TEntity, bool>>[] includeExpressions)
    {
        IncludeExpressions = includeExpressions;
    }

    public IncludeRequest(params string[] includeStrings)
    {
        IncludeStrings = includeStrings.Select(x => new IncludeModel(x)).ToArray();
    }

    public IncludeRequest(IncludeModel[] includeModels)
    {
        IncludeStrings = includeModels;
    }

    public Expression<Func<TEntity, bool>>[]? IncludeExpressions { get; private set; } = null;
    public IncludeModel[]? IncludeStrings { get; private set; } = null;


    public bool HasInclude => IncludeExpressions?.Length > 0 || IncludeStrings?.Length > 0;

}


public record IncludeModel(string Name, IncludeModel? ThenInclude = null);

