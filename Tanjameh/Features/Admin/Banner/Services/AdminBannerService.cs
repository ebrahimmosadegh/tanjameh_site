using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using Tanjameh.Infrastructure.Data;
using Radzen;
using System.Linq.Dynamic.Core;
using Tanjameh.Abstracts;


namespace Tanjameh.Features.Admin.Banner.Services;

public partial class AdminBannerService : AdminServiceBase
{
    public AdminBannerService(ApplicationDbContext context, NavigationManager navigationManager) : base(context, navigationManager)
    {
    }

    public async Task ExportBannersToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/banners/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/banners/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportBannersToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/banners/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/banners/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnBannersRead(ref IQueryable<Core.Entities.Banner> items);

    public async Task<IQueryable<Core.Entities.Banner>> GetBanners(Query query = null)
    {
        var items = Context.Banners.AsQueryable();


        if (query != null)
        {
            if (!string.IsNullOrEmpty(query.Expand))
            {
                var propertiesToExpand = query.Expand.Split(',');
                foreach (var p in propertiesToExpand)
                {
                    items = items.Include(p.Trim());
                }
            }

            ApplyQuery(ref items, query);
        }

        OnBannersRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnBannerGet(Core.Entities.Banner item);
    partial void OnGetBannerById(ref IQueryable<Core.Entities.Banner> items);


    public async Task<Core.Entities.Banner> GetBannerById(int id)
    {
        var items = Context.Banners
                          .AsNoTracking()
                          .Where(i => i.Id == id);


        OnGetBannerById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnBannerGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnBannerCreated(Core.Entities.Banner item);
    partial void OnAfterBannerCreated(Core.Entities.Banner item);

    public async Task<Core.Entities.Banner> CreateBanner(Core.Entities.Banner banner)
    {
        OnBannerCreated(banner);

        var existingItem = Context.Banners
                          .Where(i => i.Id == banner.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.Banners.Add(banner);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(banner).State = EntityState.Detached;
            throw;
        }

        OnAfterBannerCreated(banner);

        return banner;
    }

    public async Task<Core.Entities.Banner> CancelBannerChanges(Core.Entities.Banner item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnBannerUpdated(Core.Entities.Banner item);
    partial void OnAfterBannerUpdated(Core.Entities.Banner item);

    public async Task<Core.Entities.Banner> UpdateBanner(int id, Core.Entities.Banner banner)
    {
        OnBannerUpdated(banner);

        var itemToUpdate = Context.Banners
                          .Where(i => i.Id == banner.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(banner);
        entryToUpdate.State = EntityState.Modified;

        await Context.SaveChangesAsync();

        OnAfterBannerUpdated(banner);

        return banner;
    }

    partial void OnBannerDeleted(Core.Entities.Banner item);
    partial void OnAfterBannerDeleted(Core.Entities.Banner item);

    public async Task<Core.Entities.Banner> DeleteBanner(int id)
    {
        var itemToDelete = Context.Banners
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnBannerDeleted(itemToDelete);


        Context.Banners.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterBannerDeleted(itemToDelete);

        return itemToDelete;
    }

}