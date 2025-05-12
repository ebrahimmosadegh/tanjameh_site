using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class Country
{
    public int Id { get; set; }

    [StringLength(150)]
    public string CountryName { get; set; } = string.Empty;

    [StringLength(10)]
    public string CountryCode { get; set; } = string.Empty;

    [StringLength(2000)]
    public string Description { get; set; } = string.Empty;

    public List<CurrencyCountry>? CurrencyCountries { get; set; }

    [StringLength(7)]
    public string? CultureName { get; set; }
}
