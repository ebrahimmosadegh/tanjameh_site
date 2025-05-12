using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Abstracts;
using System.Text.Encodings.Web;
using Radzen;
using Tanjameh.Features.Currency.Services;


namespace Tanjameh.Features.Admin.Currency.Services;

public partial class AdminCurrencyService : AdminServiceBase
{
    private readonly CurrencyService _currencyService;

    public AdminCurrencyService(ApplicationDbContext context,
        NavigationManager navigationManager, CurrencyService currencyService) : base(context, navigationManager)
    {
        _currencyService = currencyService;
    }
    public async Task ExportCurrenciesToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/currencies/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/currencies/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportCurrenciesToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/currencies/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/currencies/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnCurrenciesRead(ref IQueryable<Core.Entities.Currency> items);

    public async Task<IQueryable<Core.Entities.Currency>> GetCurrencies(Query query = null)
    {
        var items = Context.Currencies.AsQueryable();


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

        OnCurrenciesRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnCurrencyGet(Core.Entities.Currency item);
    partial void OnGetCurrencyById(ref IQueryable<Core.Entities.Currency> items);


    public async Task<Core.Entities.Currency> GetCurrencyById(int id)
    {
        var items = Context.Currencies
                          .AsNoTracking()
                          .Where(i => i.Id == id);


        OnGetCurrencyById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnCurrencyGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnCurrencyCreated(Core.Entities.Currency item);
    partial void OnAfterCurrencyCreated(Core.Entities.Currency item);

    public async Task<Core.Entities.Currency> CreateCurrency(Core.Entities.Currency currency)
    {
        OnCurrencyCreated(currency);

        var existingItem = Context.Currencies
                          .Where(i => i.Id == currency.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.Currencies.Add(currency);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(currency).State = EntityState.Detached;
            throw;
        }

        OnAfterCurrencyCreated(currency);

        return currency;
    }

    public async Task<Core.Entities.Currency> CancelCurrencyChanges(Core.Entities.Currency item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnCurrencyUpdated(Core.Entities.Currency item, int id);
    partial void OnAfterCurrencyUpdated(Core.Entities.Currency item);

    public async Task<Core.Entities.Currency> UpdateCurrency(int id, Core.Entities.Currency currency)
    {
        OnCurrencyUpdated(currency, id);

        var itemToUpdate = Context.Currencies
                          .FirstOrDefaultAsync(i => i.Id == currency.Id);

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(currency);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterCurrencyUpdated(currency);

        return currency;
    }

    partial void OnCurrencyDeleted(Core.Entities.Currency item);
    partial void OnAfterCurrencyDeleted(Core.Entities.Currency item);

    public async Task ExportCurrencyConversionsToExcel(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/currencyconversions/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/currencyconversions/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    public async Task ExportCurrencyConversionsToCSV(Query query = null, string fileName = null)
    {
        navigationManager.NavigateTo(query != null ? query.ToUrl($"export/tanjameh_store_asp/currencyconversions/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/tanjameh_store_asp/currencyconversions/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
    }

    partial void OnCurrencyConversionsRead(ref IQueryable<Core.Entities.CurrencyConversion> items);

    public async Task<IQueryable<Core.Entities.CurrencyConversion>> GetCurrencyConversions(Query query = null)
    {
        var items = Context.CurrencyConversions.AsQueryable();

        items = items.Include(i => i.FromCurrency)
                     .Include(i => i.ToCurrency);

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

        OnCurrencyConversionsRead(ref items);

        return await Task.FromResult(items);
    }

    partial void OnCurrencyConversionGet(Core.Entities.CurrencyConversion item);
    partial void OnGetCurrencyConversionById(ref IQueryable<Core.Entities.CurrencyConversion> items);


    public async Task<Core.Entities.CurrencyConversion> GetCurrencyConversionById(int id)
    {
        var items = Context.CurrencyConversions
                          .AsNoTracking()
                          .Where(i => i.Id == id);

        items = items.Include(i => i.FromCurrency)
                     .Include(i => i.ToCurrency);

        OnGetCurrencyConversionById(ref items);

        var itemToReturn = items.FirstOrDefault();

        OnCurrencyConversionGet(itemToReturn);

        return await Task.FromResult(itemToReturn);
    }

    partial void OnCurrencyConversionCreated(Core.Entities.CurrencyConversion item);
    partial void OnAfterCurrencyConversionCreated(Core.Entities.CurrencyConversion item);

    public async Task<Core.Entities.CurrencyConversion> CreateCurrencyConversion(Core.Entities.CurrencyConversion currencyconversion)
    {
        OnCurrencyConversionCreated(currencyconversion);

        var existingItem = Context.CurrencyConversions
                          .Where(i => i.Id == currencyconversion.Id)
                          .FirstOrDefault();

        if (existingItem != null)
        {
            throw new Exception("Item already available");
        }

        try
        {
            Context.CurrencyConversions.Add(currencyconversion);
            Context.SaveChanges();
        }
        catch
        {
            Context.Entry(currencyconversion).State = EntityState.Detached;
            throw;
        }

        OnAfterCurrencyConversionCreated(currencyconversion);

        return currencyconversion;
    }

    public async Task<Core.Entities.CurrencyConversion> CancelCurrencyConversionChanges(Core.Entities.CurrencyConversion item)
    {
        var entityToCancel = Context.Entry(item);
        if (entityToCancel.State == EntityState.Modified)
        {
            entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
            entityToCancel.State = EntityState.Unchanged;
        }

        return item;
    }

    partial void OnCurrencyConversionUpdated(Core.Entities.CurrencyConversion item);
    partial void OnAfterCurrencyConversionUpdated(Core.Entities.CurrencyConversion item);

    public async Task<Core.Entities.CurrencyConversion> UpdateCurrencyConversion(int id, Core.Entities.CurrencyConversion currencyconversion)
    {
        OnCurrencyConversionUpdated(currencyconversion);

        var itemToUpdate = Context.CurrencyConversions
                          .Where(i => i.Id == currencyconversion.Id)
                          .FirstOrDefault();

        if (itemToUpdate == null)
        {
            throw new Exception("Item no longer available");
        }

        var entryToUpdate = Context.Entry(itemToUpdate);
        entryToUpdate.CurrentValues.SetValues(currencyconversion);
        entryToUpdate.State = EntityState.Modified;

        Context.SaveChanges();

        OnAfterCurrencyConversionUpdated(currencyconversion);

        return currencyconversion;
    }

    partial void OnCurrencyConversionDeleted(Core.Entities.CurrencyConversion item);
    partial void OnAfterCurrencyConversionDeleted(Core.Entities.CurrencyConversion item);

}