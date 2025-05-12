using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Text.Encodings.Web;
using Tanjameh.Abstracts;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Admin.Product.Services;

public partial class ProductService : AdminServiceBase
{
    public ProductService(ApplicationDbContext context, NavigationManager navigationManager) : base(context, navigationManager)
    {
    }

    public async Task ExportProductsToExcel(Query? query = null, string? fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/products/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportProductsToCSV(Query? query = null, string? fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/products/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnProductsRead(ref IQueryable<Core.Entities.Product> items);

    public async Task<IQueryable<Core.Entities.Product>> GetProducts(Query query = null)
    {
        var items = Context.Products.AsQueryable();

        items = items.Include(i => i.PriceCurrency);

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

        OnProductsRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnProductGet(Core.Entities.Product item);
    partial void OnGetProductById(ref IQueryable<Core.Entities.Product> items);


    public async Task<Core.Entities.Product> GetProductById(int id)
    {
        var items = Context.Products
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.PriceCurrency);

        OnGetProductById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnProductGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnProductCreated(Core.Entities.Product item);
    partial void OnAfterProductCreated(Core.Entities.Product item);

    public async Task<Core.Entities.Product> CreateProduct(Core.Entities.Product product)
    {
        OnProductCreated(product);

        var existingItem = Context.Products
                          .Where(i => i.Id == product.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.Products.Add(product);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(product).State = EntityState.Detached;
            throw;
        }

        OnAfterProductCreated(product);

        return product;
    }

    public async Task<Core.Entities.Product> CancelProductChanges(Core.Entities.Product item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnProductUpdated(Core.Entities.Product item);
    partial void OnAfterProductUpdated(Core.Entities.Product item);

    public async Task<Core.Entities.Product> UpdateProduct(int id, Core.Entities.Product product)
    {
        OnProductUpdated(product);

        var itemToUpdate = Context.Products
                          .Where(i => i.Id == product.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(product);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterProductUpdated(product);

        return product;
    }

    partial void OnProductDeleted(Core.Entities.Product item);
    partial void OnAfterProductDeleted(Core.Entities.Product item);

    public async Task<Core.Entities.Product> DeleteProduct(int id)
    {
        var itemToDelete = Context.Products
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnProductDeleted(itemToDelete);


        Context.Products.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterProductDeleted(itemToDelete);

        return itemToDelete;
    }

    public async Task<Core.Entities.Product> HideProduct(int id, bool isHide)
    {
        var itemToUpdate = Context.Products.IgnoreQueryFilters()
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }


        itemToUpdate.Hidden = isHide;

        if (!isHide)
        {
            itemToUpdate.PublishDate = DateTime.Now;
        }

        await Context.SaveChangesAsync();

        return itemToUpdate!;
    }

    public async Task<Core.Entities.Product> RejectProduct(int id, bool isRejected = true)
    {
        var itemToUpdate = Context.Products.IgnoreQueryFilters()
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }


        itemToUpdate.Rejected = isRejected;

        await Context.SaveChangesAsync();

        return itemToUpdate!;
    }

}
