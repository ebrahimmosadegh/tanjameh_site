using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class Currency
{
    public int Id { get; init; }

    [StringLength(10)]
    public string CurrencyCode { get; set; } = string.Empty;

    [StringLength(100)]
    public string CurrencyName { get; set; } = string.Empty;

    [StringLength(2000)]
    public string Description { get; set; } = string.Empty;

    [StringLength(10)]
    public string? CurrencySign { get; set; } 

    [StringLength(50)]
    public string? CustomStringFormat { get; set; }

    [StringLength(7)]
    public string? DefaultCultureName { get; set; }

    public ICollection<CurrencyCountry>? CurrencyCountries { get; set; }
}
