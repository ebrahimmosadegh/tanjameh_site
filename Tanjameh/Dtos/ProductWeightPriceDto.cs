using Tanjameh.Features.Currency.Services;

namespace Tanjameh.Dtos;

public class ProductWeightPriceDto
{
    private int? _requestCurrencyId;

    public ProductWeightPriceDto()
    {

    }

    public ProductWeightPriceDto(int? requestCurrencyId)
    {
        _requestCurrencyId = requestCurrencyId;
    }


    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public string GetPriceText(int? requestCurrencyId = null)
    {
        return CurrencyService.ExchangeAndFormatting(Price, requestCurrencyId ?? _requestCurrencyId ?? 2, 1)!;
    }

    public Core.Entities.WeightSource WeightSource { get; set; }

}
