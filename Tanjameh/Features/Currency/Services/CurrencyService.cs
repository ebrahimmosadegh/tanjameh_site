using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;
using System.Globalization;
using System.Numerics;
using System.Text;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Currency.Services;

public sealed class CurrencyService
{
    private const string CurrencyNotFoundExceptionMessage = "Currency Conversion from {0} to {1} Not Found";

    private static ConcurrentBag<Core.Entities.CurrencyConversion> Conversions = new();
    private static ConcurrentBag<Core.Entities.Currency> Currencies = new();

    private readonly ApplicationDbContext _dbContext;

    public CurrencyService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool RefreshConversions()
    {      
        var currencyConversions =  _dbContext.CurrencyConversions
           .Include(x => x.FromCurrency)
           .Include(x => x.ToCurrency)
            .ToList();

        var currencies =  _dbContext.Currencies.ToList();

        Conversions = new ConcurrentBag<Core.Entities.CurrencyConversion>(currencyConversions);
        Currencies = new ConcurrentBag<Core.Entities.Currency>(currencies);

        return true;
    }

    public static decimal Exchange<T>(T value, int fromCurrencyId, int toCurrencyId) where T : INumber<T>
    {
        var conversion = Conversions.FirstOrDefault(x => x.FromCurrencyId == fromCurrencyId && x.ToCurrencyId == toCurrencyId);

        if (conversion is null)
        {
            throw new ArgumentException(string.Format(CurrencyNotFoundExceptionMessage, fromCurrencyId, toCurrencyId));
        }

        decimal decimalValue = decimal.CreateChecked(value);
        return decimalValue * conversion.ExchangeRate;
    }

    public static decimal Exchange<T>(T value, string fromCurrencyCode, string toCurrencyCode) where T : INumber<T>
    {
        var conversion = Conversions.FirstOrDefault(x => x.FromCurrency.CurrencyCode == fromCurrencyCode && x.ToCurrency.CurrencyCode == toCurrencyCode);

        if (conversion is null)
        {
            throw new ArgumentException(string.Format(CurrencyNotFoundExceptionMessage, fromCurrencyCode, toCurrencyCode));
        }

        decimal decimalValue = decimal.CreateChecked(value);
        return decimalValue * conversion.ExchangeRate;
    }

    public static string? ExchangeAndFormatting<T>(T value, int fromCurrencyId, int toCurrencyId) where T : INumber<T>
    {
        return ExchangeAndFormattingInternal(value,
            x => x.Id == fromCurrencyId,
            x => x.FromCurrencyId == fromCurrencyId && x.ToCurrencyId == toCurrencyId);
    }

    public static string? ExchangeAndFormatting<T>(T value, string fromCurrencyCode, string toCurrencyCode) where T : INumber<T>
    {
        return ExchangeAndFormattingInternal(value,
            x => x.CurrencyCode == fromCurrencyCode,
            x => x.FromCurrency.CurrencyCode == fromCurrencyCode && x.ToCurrency.CurrencyCode == toCurrencyCode);
    }

    private static string? ExchangeAndFormattingInternal<T>(T value, Func<Core.Entities.Currency, bool> currencyPredicate, Func<Core.Entities.CurrencyConversion, bool> conversionPredicate) where T : INumber<T>
    {
        decimal exchangeRate = 1;
        decimal decimalValue = decimal.CreateChecked(value);

        var conversion = Conversions.FirstOrDefault(conversionPredicate);
        Core.Entities.Currency destCurrency;

        if (conversion is null)
        {
            destCurrency = Currencies.First(currencyPredicate);
        }
        else
        {
            destCurrency = conversion.ToCurrency;
            exchangeRate = conversion.ExchangeRate;
        }

        var exchangedValue = decimalValue * exchangeRate;

        return Formatting(exchangedValue, destCurrency);


    }


    public static string? ConvertDigitsBaseOnCultureName(string input, string? cultureName)
    {
        if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(cultureName))
            return input;


        if (!cultureName.StartsWith("fa-") && !cultureName.StartsWith("ar-"))
            return input;

        var culture = new CultureInfo("ar");

        var arabicDigits = culture.NumberFormat.NativeDigits;
        var result = new StringBuilder(input.Length);

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                int digitValue = c - '0';
                result.Append(arabicDigits[digitValue]);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    public static string? Formatting(decimal exchangedValue, int? destCurrencyId = null)
    {
        Core.Entities.Currency? destCurrency = null;
        if (destCurrencyId.HasValue)
        {
            destCurrency = Currencies.FirstOrDefault(x => x.Id == destCurrencyId);
        }
        return Formatting(exchangedValue, destCurrency);
    }

    public static string? Formatting(decimal exchangedValue, Core.Entities.Currency? destCurrency = null)
    {
        if (destCurrency == null)
        {
            destCurrency = Currencies.First(x => x.CurrencyCode == "IRR");
        }

        string stringFormat = string.IsNullOrEmpty(destCurrency.CustomStringFormat) ? "N2" : destCurrency.CustomStringFormat;

        var result = ConvertDigitsBaseOnCultureName(!string.IsNullOrEmpty(destCurrency.DefaultCultureName)
            ? exchangedValue.ToString(stringFormat, new CultureInfo(destCurrency.DefaultCultureName))
            : exchangedValue.ToString(stringFormat), destCurrency.DefaultCultureName);

        return string.IsNullOrEmpty(result) ? result : result + destCurrency.CurrencySign;
    }
}
