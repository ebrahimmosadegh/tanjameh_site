
using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Currency.Services;

public partial class AdminCurrencyService
{
 
    partial void OnCurrencyUpdated(Core.Entities.Currency item, int id)
    {
        var currency = Context.Currencies.Find(id);

        if (currency != null && string.IsNullOrEmpty(currency.CurrencyCode))
        {
            item.CurrencyCode = currency.CurrencyCode;
        }
    }

    //todo cant set 2 Conversion ...
    partial void OnCurrencyConversionCreated(CurrencyConversion item)
    {
        item.LastUpdated = DateTime.UtcNow;
    }

    partial void OnCurrencyConversionUpdated(CurrencyConversion item)
    {
        item.LastUpdated = DateTime.UtcNow;
    }
}
