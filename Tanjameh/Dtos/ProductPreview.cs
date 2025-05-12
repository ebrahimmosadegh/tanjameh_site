using Tanjameh.Features.Currency.Services;

namespace Tanjameh.Dtos;


public class ProductPreviewDto
{
    private int? _requestCurrencyId;

    public ProductPreviewDto()
    {

    }

    public ProductPreviewDto(int? requestCurrencyId)
    {
        _requestCurrencyId = requestCurrencyId;
    }

    public required int ProductId { get; init; }

    public required string Name { get; init; }

    public required string Url { get; set; }

    public required string? ThumbnailImageUrl { get; set; }

    public string?[]? ThumbnailImageUrls { get; set; }

    public decimal Price { private get; init; }

    public decimal? OldPrice { private get; init; }

    public int? CurrencyId { private get; init; }

    public string GetPriceText(int? requestCurrencyId = null)
    {
        return CurrencyService.ExchangeAndFormatting(Price, requestCurrencyId ?? _requestCurrencyId ?? 2, 1)!;
    }

    public string? GetOldPriceText(int? requestCurrencyId = null)
    {
        return CurrencyService.ExchangeAndFormatting(Price, requestCurrencyId ?? _requestCurrencyId ?? 2, 1);
    }


    public bool HasOldPrice => OldPrice != null && Price < OldPrice;

    public string? CategoryName { get; set; }
    public string? ProductTypeName { get; set; }
}


