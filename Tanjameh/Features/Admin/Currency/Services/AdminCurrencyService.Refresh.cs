using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Currency.Services;

public partial class AdminCurrencyService
{
    partial void OnAfterCurrencyConversionCreated(CurrencyConversion item)
    {
        _currencyService.RefreshConversions();
    }

    partial void OnAfterCurrencyConversionUpdated(CurrencyConversion item)
    {
        _currencyService.RefreshConversions();
    }



}
