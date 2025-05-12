using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using Tanjameh.Infrastructure.Data;
using Radzen;
using System.Linq.Dynamic.Core;
using Tanjameh.Abstracts;
using Tanjameh.Core.Entities;
using Tanjameh.Dtos;


namespace Tanjameh.Features.Admin.Media.Services;

public partial class MediaService : AdminServiceBase
{
    const string DefaultProductImagePath = @"wwwroot\images\products\default.jpg";

    public MediaService(ApplicationDbContext context, NavigationManager navigationManager) : base(context, navigationManager)
    {
    }

    public async Task ExportMediaFilesToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/mediafiles/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/mediafiles/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportMediaFilesToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/mediafiles/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/mediafiles/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }


    public async Task<IQueryable<Core.Entities.ProductMediaFile>> GetProductMedia(Query query = null)
    {
        var items = Context.ProductMediaFile.IgnoreQueryFilters().OrderByDescending(x => x.Id).AsQueryable();


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

        return await Task.FromResult(items);
    }

    partial void OnMediaFileGet(Core.Entities.MediaFile item);
    partial void OnGetMediaFileById(ref IQueryable<Core.Entities.MediaFile> items);


    public async Task<Core.Entities.ProductMediaFile> ProductMediaById(int id)
    {
        var items = Context.ProductMediaFile.IgnoreQueryFilters()
                          .AsNoTracking()
                          .Where(i => i.Id == id);


        var itemToReturn = items.FirstOrDefault();


        return await Task.FromResult(itemToReturn);
    }

    public async Task UpdateProductMediaOrder(List<Core.Entities.ProductMediaFile> productMediaFiles)
    {

        var query = Context.ProductMediaFile.IgnoreQueryFilters();

        foreach (var productMediaFile in productMediaFiles)
        {

            var itemToUpdate = query.FirstOrDefault(i => i.Id == productMediaFile.Id);

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(productMediaFile);
            entryToUpdate.State = EntityState.Modified;
        }


        Context.SaveChanges();
    }
    

    public async Task<Core.Entities.ProductMediaFile> HideProductMedia(int id, bool isHide)
    {

        var itemToUpdate = Context.ProductMediaFile.IgnoreQueryFilters()
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }


        if (itemToUpdate.ThumbnailFile?.Hidden != isHide || itemToUpdate.MediaFile?.Hidden != isHide)
        {
            if (itemToUpdate.MediaFile != null)
            {
                var filePath = Path.Combine(itemToUpdate.MediaFile.MediaFolder ?? "", itemToUpdate.MediaFile.Name);
                //UpdateProductThumbnial(filePath);
            }
            if (itemToUpdate.ThumbnailFile != null)
            {
                var filePath = Path.Combine(itemToUpdate.ThumbnailFile.MediaFolder ?? "", itemToUpdate.ThumbnailFile.Name);
                UpdateProductThumbnial(filePath);
            }
        }

        itemToUpdate.Hidden = isHide;

        Context.SaveChanges();

        return itemToUpdate!;
    }

    private void UpdateProductThumbnial(string filePath)
    {
        var product = Context.Products.FirstOrDefault(x => x.MainPictureFileName == filePath);
        if (product != null)
        {
            var firstImage = product.ProductMediaFiles.FirstOrDefault(x => x.ThumbnailFile != null)?.ThumbnailFile;
            if (firstImage != null)
            {
                product.MainPictureFileName = Path.Combine(firstImage.MediaFolder ?? "", firstImage.Name);
            }
            else
            {
                product.MainPictureFileName = DefaultProductImagePath;
            }
        }
    }

    public async Task<Core.Entities.ProductMediaFile> DeleteProductMedia(int id)
    {
        var itemToDelete = Context.ProductMediaFile.IgnoreQueryFilters()
                          .Include(x => x.MediaFile)
                          .Include(x => x.ThumbnailFile)
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        string? thFilePath = null;
        if (itemToDelete.MediaFile != null)
        {
            thFilePath = Path.Combine(itemToDelete.ThumbnailFile.MediaFolder ?? "", itemToDelete.ThumbnailFile.Name);
        }
        string? filePath = null;
        if (itemToDelete.MediaFile != null)
        {
            filePath = Path.Combine(itemToDelete.MediaFile.MediaFolder ?? "", itemToDelete.MediaFile.Name);
        }

        Context.ProductMediaFile.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }


        if (thFilePath != null)
        {
            UpdateProductThumbnial(thFilePath);
            Context.SaveChanges();
        }


        try
        {
            if (thFilePath != null && File.Exists(thFilePath))
                File.Delete(thFilePath);

            if (filePath != null && File.Exists(filePath))
                File.Delete(filePath);
        }
        catch (Exception ex)
        {
            throw new Exception($"File Can't delete", ex);
        }


        return itemToDelete;
    }
    
    
    //todo move to another service
    public  IEnumerable<Lookup> GetCatalogBrands()
    {
       return Context.CatalogBrands.Select(x=> new Lookup{Id = x.Id, Title = x.Name});
    }

    public IEnumerable<Lookup> GetProductTypes()
    {
        return Context.ProductTypes.Select(x=> new Lookup{Id = x.Id, Title = x.Name});
    }
}