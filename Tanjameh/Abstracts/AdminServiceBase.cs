using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Linq.Dynamic.Core;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Abstracts;

public abstract class AdminServiceBase
{
    protected ApplicationDbContext Context
    {
        get
        {
            return this.context;
        }
    }

    private readonly ApplicationDbContext context;
    protected readonly NavigationManager navigationManager;

    public AdminServiceBase(ApplicationDbContext context, NavigationManager navigationManager)
    {
        this.context = context;
        this.navigationManager = navigationManager;
    }

    public void Reset() => Context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

    public void ApplyQuery<T>(ref IQueryable<T> items, Query query = null)
    {
        if (query != null)
        {
            if (!string.IsNullOrEmpty(query.Filter))
            {
                if (query.FilterParameters != null)
                {
                    items = items.Where(query.Filter, query.FilterParameters);
                }
                else
                {
                    items = items.Where(query.Filter);
                }
            }

            if (!string.IsNullOrEmpty(query.OrderBy))
            {
                items = items.OrderBy(query.OrderBy);
            }

            if (query.Skip.HasValue)
            {
                items = items.Skip(query.Skip.Value);
            }

            if (query.Top.HasValue)
            {
                items = items.Take(query.Top.Value);
            }
        }
    }



}
