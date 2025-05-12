namespace Tanjameh.Core.Entities;

public class CurrencyCountry
{
    public int Id { get; init; }

    public int CountryId { get; set; }
    public Country Country { get; set; } = default!;

    public int CurrencyId { get; set; }
    public Currency Currency { get; set; } = default!;
}
