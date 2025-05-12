using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using Tanjameh.Infrastructure.Data;
using Radzen;
using System.Linq.Dynamic.Core;
using Tanjameh.Abstracts;
using DocumentFormat.OpenXml.InkML;
using System.Threading;
using Tanjameh.Core.Entities;
using Tanjameh.Features.Admin.Category.Models;


namespace Tanjameh.Features.Admin.Category.Services;

public partial class AdminCategoryService : AdminServiceBase
{
    private readonly ILogger<AdminCategoryService> _logger;

    public AdminCategoryService(ApplicationDbContext context,
        NavigationManager navigationManager, ILogger<AdminCategoryService> logger) : base(context, navigationManager)
    {
        _logger = logger;
    }

    public async Task ExportCategoriesToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/categories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/categories/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportCategoriesToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/categories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/categories/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnCategoriesRead(ref IQueryable<Core.Entities.Category> items);

    public async Task<IQueryable<Core.Entities.Category>> GetCategories(Query query = null)
    {
        var items = Context.Categories.AsQueryable();

        items = items.Include(i => i.ParentCategory);
        items = items.Include(i => i.SubCategories);

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

        OnCategoriesRead(ref items);

        return await Task.FromResult(items);
    }

    public IQueryable<Core.Entities.Category> GetRelativeCategories(int categoryId, Query query = null)
    {
        var items = Context.Categories.AsQueryable();

        items = items.Include(i => i.ParentCategory);
        items = items.Include(i => i.SubCategories);

        items =  items.Where(x => x.Id == categoryId || x.ParentCategoryId == categoryId);



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

        OnCategoriesRead(ref items);

        return items;
    }

    

    partial void OnCategoryGet(Core.Entities.Category item);
    partial void OnGetCategoryById(ref IQueryable<Core.Entities.Category> items);


    public async Task<Core.Entities.Category> GetCategoryById(int id)
    {
        var items = Context.Categories
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.ParentCategory);

        OnGetCategoryById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnCategoryGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnCategoryCreated(Core.Entities.Category item);
    partial void OnAfterCategoryCreated(Core.Entities.Category item);

    public async Task<Core.Entities.Category> CreateCategory(Core.Entities.Category category)
    {
        OnCategoryCreated(category);

        var existingItem = Context.Categories
                           .AsNoTracking()
                          .Where(i => i.Id == category.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.Categories.Add(category);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(category).State = EntityState.Detached;
            throw;
        }

        OnAfterCategoryCreated(category);

        return category;
    }

    public async Task<Core.Entities.Category> CancelCategoryChanges(Core.Entities.Category item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnCategoryUpdated(Core.Entities.Category item);
    partial void OnAfterCategoryUpdated(Core.Entities.Category item);

    public async Task<Core.Entities.Category> UpdateCategory(int id, Core.Entities.Category category)
    {
        OnCategoryUpdated(category);

        var itemToUpdate = Context.Categories
                          .Where(i => i.Id == category.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(category);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterCategoryUpdated(category);

        return category;
    }

    partial void OnCategoryDeleted(Core.Entities.Category item);
    partial void OnAfterCategoryDeleted(Core.Entities.Category item);

    public async Task<Core.Entities.Category> DeleteCategory(int id)
    {
        var itemToDelete = Context.Categories
                          .Where(i => i.Id == id)
                          .Include(i => i.SiteCategoryToApis)
                          .Include(i => i.ParentCategory)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnCategoryDeleted(itemToDelete);


        Context.Categories.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterCategoryDeleted(itemToDelete);

        return itemToDelete;
    }

    public async Task ExportSiteCategoryToApisToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/sitecategorytoapis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/sitecategorytoapis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportSiteCategoryToApisToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/sitecategorytoapis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/sitecategorytoapis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnSiteCategoryToApisRead(ref IQueryable<Core.Entities.SiteCategoryToApi> items);

    public async Task<IQueryable<Core.Entities.SiteCategoryToApi>> GetSiteCategoryToApis(Query query = null)
    {
        var items = Context.SiteCategoryToApis.AsQueryable();

        items = items.Include(i => i.ApiCategory);
        items = items.Include(i => i.SiteCategory);

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

        OnSiteCategoryToApisRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnSiteCategoryToApiGet(Core.Entities.SiteCategoryToApi item);
    partial void OnGetSiteCategoryToApiById(ref IQueryable<Core.Entities.SiteCategoryToApi> items);


    public async Task<Core.Entities.SiteCategoryToApi> GetSiteCategoryToApiById(long id)
    {
        var items = Context.SiteCategoryToApis
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.ApiCategory);
        items = items.Include(i => i.SiteCategory);

        OnGetSiteCategoryToApiById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnSiteCategoryToApiGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnSiteCategoryToApiCreated(Core.Entities.SiteCategoryToApi item);
    partial void OnAfterSiteCategoryToApiCreated(Core.Entities.SiteCategoryToApi item);

    public async Task<Core.Entities.SiteCategoryToApi> CreateSiteCategoryToApi(Core.Entities.SiteCategoryToApi sitecategorytoapi)
    {
        OnSiteCategoryToApiCreated(sitecategorytoapi);

        var existingItem = Context.SiteCategoryToApis
                          .AsNoTracking()
                          .Where(i => i.Id == sitecategorytoapi.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.SiteCategoryToApis.Add(sitecategorytoapi);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(sitecategorytoapi).State = EntityState.Detached;
            throw;
        }

        OnAfterSiteCategoryToApiCreated(sitecategorytoapi);

        return sitecategorytoapi;
    }

    public async Task<Core.Entities.SiteCategoryToApi> CancelSiteCategoryToApiChanges(Core.Entities.SiteCategoryToApi item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnSiteCategoryToApiUpdated(Core.Entities.SiteCategoryToApi item);
    partial void OnAfterSiteCategoryToApiUpdated(Core.Entities.SiteCategoryToApi item);

    public async Task<Core.Entities.SiteCategoryToApi> UpdateSiteCategoryToApi(long id, Core.Entities.SiteCategoryToApi sitecategorytoapi)
    {
        OnSiteCategoryToApiUpdated(sitecategorytoapi);

        var itemToUpdate = Context.SiteCategoryToApis
                          .Where(i => i.Id == sitecategorytoapi.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(sitecategorytoapi);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterSiteCategoryToApiUpdated(sitecategorytoapi);

        return sitecategorytoapi;
    }

    partial void OnSiteCategoryToApiDeleted(Core.Entities.SiteCategoryToApi item);
    partial void OnAfterSiteCategoryToApiDeleted(Core.Entities.SiteCategoryToApi item);

    public async Task<Core.Entities.SiteCategoryToApi> DeleteSiteCategoryToApi(long id)
    {
        var itemToDelete = Context.SiteCategoryToApis
                          .Where(i => i.Id == id)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnSiteCategoryToApiDeleted(itemToDelete);


        Context.SiteCategoryToApis.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterSiteCategoryToApiDeleted(itemToDelete);

        return itemToDelete;
    }

    public async Task ExportCategoryApisToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/categoryapis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/categoryapis/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportCategoryApisToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/categoryapis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/categoryapis/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnCategoryApisRead(ref IQueryable<Core.Entities.CategoryApi> items);

    public async Task<IQueryable<Core.Entities.CategoryApi>> GetCategoryApis(Query? query = null)
    {
        var items = Context.CategoryApis.AsQueryable();

        items = items.Include(i => i.ParentCategory);

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

        OnCategoryApisRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnCategoryApiGet(Core.Entities.CategoryApi item);
    partial void OnGetCategoryApiById(ref IQueryable<Core.Entities.CategoryApi> items);


    public async Task<Core.Entities.CategoryApi> GetCategoryApiById(int id)
    {
        var items = Context.CategoryApis
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.ParentCategory);

        OnGetCategoryApiById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnCategoryApiGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnCategoryApiCreated(Core.Entities.CategoryApi item);
    partial void OnAfterCategoryApiCreated(Core.Entities.CategoryApi item);

    public async Task<Core.Entities.CategoryApi> CreateCategoryApi(Core.Entities.CategoryApi categoryapi)
    {
        OnCategoryApiCreated(categoryapi);

        var existingItem = Context.CategoryApis
                          .Where(i => i.Id == categoryapi.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.CategoryApis.Add(categoryapi);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(categoryapi).State = EntityState.Detached;
            throw;
        }

        OnAfterCategoryApiCreated(categoryapi);

        return categoryapi;
    }

    public async Task<Core.Entities.CategoryApi> CancelCategoryApiChanges(Core.Entities.CategoryApi item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnCategoryApiUpdated(Core.Entities.CategoryApi item);
    partial void OnAfterCategoryApiUpdated(Core.Entities.CategoryApi item);

    public async Task<Core.Entities.CategoryApi> UpdateCategoryApi(int id, Core.Entities.CategoryApi categoryapi)
    {
        OnCategoryApiUpdated(categoryapi);

        var itemToUpdate = Context.CategoryApis
                          .Where(i => i.Id == categoryapi.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(categoryapi);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterCategoryApiUpdated(categoryapi);

        return categoryapi;
    }

    partial void OnCategoryApiDeleted(Core.Entities.CategoryApi item);
    partial void OnAfterCategoryApiDeleted(Core.Entities.CategoryApi item);

    public async Task<Core.Entities.CategoryApi> DeleteCategoryApi(int id)
    {
        var itemToDelete = Context.CategoryApis
                          .Where(i => i.Id == id)
                          .Include(i => i.SiteCategoryToApis)
                          .Include(i => i.ParentCategory)
                          .FirstOrDefault();

        if (itemToDelete == null)
        {
            throw new Exception("Item no longer available");
        }

        OnCategoryApiDeleted(itemToDelete);


        Context.CategoryApis.Remove(itemToDelete);

        try
        {
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(itemToDelete).State = EntityState.Unchanged;
            throw;
        }

        OnAfterCategoryApiDeleted(itemToDelete);

        return itemToDelete;
    }

    private async Task ImportCategoryTree(CategoryImport importCategory, int? parentId = null)
    {
        Core.Entities.Category? existingCategory = null;

        var gender = importCategory.GenderId == 1 ? GenderType.Men : GenderType.Women;
        if (importCategory.Id.HasValue)
        {
            existingCategory = Context.Categories
                .FirstOrDefault(c => c.Id == importCategory.Id && c.ParentCategoryId == parentId);
        }
        else
        {
            existingCategory = Context.Categories
                .FirstOrDefault(c => c.Name == importCategory.Name && c.GenderTypeId == (int)gender && c.ParentCategoryId == parentId);
        }
        
        if (existingCategory == null)
        {
            var newCategory = new Core.Entities.Category
            {
                Name = importCategory.Name,
                Description = importCategory.Description,
                Slug = importCategory.Slug,
                ParentCategoryId = parentId,
                GenderType = gender,
            };

            Context.Categories.Add(newCategory);
            Context.SaveChanges();

            if (importCategory.SubCategories?.Any() == true)
            {
                foreach (var subCategory in importCategory.SubCategories)
                {
                    await ImportCategoryTree(subCategory, newCategory.Id);
                }
            }
        }
        else if (importCategory.SubCategories?.Any() == true)
        {
            foreach (var subCategory in importCategory.SubCategories)
            {
                await ImportCategoryTree(subCategory, existingCategory.Id);
            }
        }
    }

    public async Task<bool> ImportCategories(string jsonContent)
    {
        try
        {
            var categories = System.Text.Json.JsonSerializer.Deserialize<List<CategoryImport>>(jsonContent,
                new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (categories == null) return false;

            foreach (var category in categories)
            {
                await ImportCategoryTree(category);
            }

            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(exception: e, $"Import of Categories Error: {e.Message}");
            return false;
        }
    }
}