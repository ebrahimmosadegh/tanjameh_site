using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Abstracts;
using System.Text.Encodings.Web;
using Radzen;
using Tanjameh.Features.Currency.Services;


namespace Tanjameh.Features.Admin.Weight.Services;

public partial class WeightService : AdminServiceBase
{

    public WeightService(ApplicationDbContext context,
        NavigationManager navigationManager, CurrencyService currencyService) : base(context, navigationManager)
    {
    }

    public async Task ExportWeightSourcesToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/weightsources/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/weightsources/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportWeightSourcesToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/weightsources/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/weightsources/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnWeightSourcesRead(ref IQueryable<Core.Entities.WeightSource> items);

    public async Task<IQueryable<Core.Entities.WeightSource>> GetWeightSources(Query query = null)
    {
        var items = Context.WeightSource.AsQueryable();


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

        OnWeightSourcesRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnWeightSourceGet(Core.Entities.WeightSource item);
    partial void OnGetWeightSourceById(ref IQueryable<Core.Entities.WeightSource> items);


    public async Task<Core.Entities.WeightSource> GetWeightSourceById(int id)
    {
        var items = Context.WeightSource
                          .AsNoTracking()
                          .Where(i => i.Id == id);


        OnGetWeightSourceById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnWeightSourceGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnWeightSourceCreated(Core.Entities.WeightSource item);
    partial void OnAfterWeightSourceCreated(Core.Entities.WeightSource item);

    public async Task<Core.Entities.WeightSource> CreateWeightSource(Core.Entities.WeightSource weightsource)
    {
        OnWeightSourceCreated(weightsource);

        var existingItem = Context.WeightSource
                          .Where(i => i.Id == weightsource.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.WeightSource.Add(weightsource);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(weightsource).State = EntityState.Detached;
            throw;
        }

        OnAfterWeightSourceCreated(weightsource);

        return weightsource;
    }

    public async Task<Core.Entities.WeightSource> CancelWeightSourceChanges(Core.Entities.WeightSource item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnWeightSourceUpdated(Core.Entities.WeightSource item);
    partial void OnAfterWeightSourceUpdated(Core.Entities.WeightSource item);

    public async Task<Core.Entities.WeightSource> UpdateWeightSource(int id, Core.Entities.WeightSource weightsource)
    {
        OnWeightSourceUpdated(weightsource);

        var itemToUpdate = Context.WeightSource
                          .Where(i => i.Id == weightsource.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(weightsource);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterWeightSourceUpdated(weightsource);

        return weightsource;
    }

    partial void OnWeightSourceDeleted(Core.Entities.WeightSource item);
    partial void OnAfterWeightSourceDeleted(Core.Entities.WeightSource item);

    public async Task<Core.Entities.WeightSource> DeleteWeightSource(int id)
    {
        var itemToDelete = Context.WeightSource
                          .Where(i => i.Id == id)
                          .Include(i => i.ProductWeightPrice)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnWeightSourceDeleted(itemToDelete);


        Context.WeightSource.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterWeightSourceDeleted(itemToDelete);

        return itemToDelete;
    }

    public async Task ExportProductWeightPricesToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/productweightprices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/productweightprices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportProductWeightPricesToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/productweightprices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/productweightprices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnProductWeightPricesRead(ref IQueryable<Core.Entities.ProductWeightPrice> items);

    public async Task<IQueryable<Core.Entities.ProductWeightPrice>> GetProductWeightPrices(Query query = null)
    {
        var items = Context.ProductWeightPrice.AsQueryable();

        items = items.Include(i => i.Currency);
        items = items.Include(i => i.Weight);

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

        OnProductWeightPricesRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnProductWeightPriceGet(Core.Entities.ProductWeightPrice item);
    partial void OnGetProductWeightPriceById(ref IQueryable<Core.Entities.ProductWeightPrice> items);


    public async Task<Core.Entities.ProductWeightPrice> GetProductWeightPriceById(int id)
    {
        var items = Context.ProductWeightPrice
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.Currency);
        items = items.Include(i => i.Weight);

        OnGetProductWeightPriceById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnProductWeightPriceGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnProductWeightPriceCreated(Core.Entities.ProductWeightPrice item);
    partial void OnAfterProductWeightPriceCreated(Core.Entities.ProductWeightPrice item);

    public async Task<Core.Entities.ProductWeightPrice> CreateProductWeightPrice(Core.Entities.ProductWeightPrice productweightprice)
    {
        OnProductWeightPriceCreated(productweightprice);

        var existingItem = Context.ProductWeightPrice
                          .Where(i => i.Id == productweightprice.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.ProductWeightPrice.Add(productweightprice);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(productweightprice).State = EntityState.Detached;
            throw;
        }

        OnAfterProductWeightPriceCreated(productweightprice);

        return productweightprice;
    }

    public async Task<Core.Entities.ProductWeightPrice> CancelProductWeightPriceChanges(Core.Entities.ProductWeightPrice item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnProductWeightPriceUpdated(Core.Entities.ProductWeightPrice item);
    partial void OnAfterProductWeightPriceUpdated(Core.Entities.ProductWeightPrice item);

    public async Task<Core.Entities.ProductWeightPrice> UpdateProductWeightPrice(int id, Core.Entities.ProductWeightPrice productweightprice)
    {
        OnProductWeightPriceUpdated(productweightprice);

        var itemToUpdate = Context.ProductWeightPrice
                          .Where(i => i.Id == productweightprice.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(productweightprice);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterProductWeightPriceUpdated(productweightprice);

        return productweightprice;
    }

    partial void OnProductWeightPriceDeleted(Core.Entities.ProductWeightPrice item);
    partial void OnAfterProductWeightPriceDeleted(Core.Entities.ProductWeightPrice item);

    public async Task<Core.Entities.ProductWeightPrice> DeleteProductWeightPrice(int id)
    {
        var itemToDelete = Context.ProductWeightPrice
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnProductWeightPriceDeleted(itemToDelete);


        Context.ProductWeightPrice.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterProductWeightPriceDeleted(itemToDelete);

        return itemToDelete;
    }
}

