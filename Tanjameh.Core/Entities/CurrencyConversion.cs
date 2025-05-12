using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class CurrencyConversion
{
    public int Id { get; init; }

    public int FromCurrencyId { get; set; }
    public Currency FromCurrency { get; set; } = null!;

    public int ToCurrencyId { get; set; }
    public Currency ToCurrency { get; set; } = null!;

    [Range(0, double.MaxValue)]
    public decimal ExchangeRate { get; set; }

    public DateTime LastUpdated { get; set; }

    [StringLength(2000)]
    public string? Notes { get; set; }
}
