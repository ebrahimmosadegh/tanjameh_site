using System.Text.Json;

namespace Tanjameh.Dtos;

public class ProductPriceDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int? PriceCurrencyId { get; set; }

    public decimal? OldPrice { get; set; }
    public long? CustomePriceKey { get; set; }
}


public class ProductInfoDto : ProductPriceDto
{

    public string Name { get; set; } = string.Empty;

    public string? FullDescription { get; set; }
    public string Slug { get; set; } = string.Empty;

    public int? BrandId { get; set; }
    public string? BrandUrl { get; set; }
    public string? BrandName { get; set; }
    public string BrandDescription { get; set; } = string.Empty;


    private Dictionary<string, string>? FullDescriptionDict = null;
    public Dictionary<string, string>? GetFullDescriptionObject()
    {
        if (FullDescription is null)
            return null;
        try
        {
            if (FullDescriptionDict is null)
                FullDescriptionDict = JsonSerializer.Deserialize<Dictionary<string, string>>(FullDescription);

            return FullDescriptionDict;
        }
        catch (Exception ex)
        {
            return new Dictionary<string, string>() { { "Info", FullDescription } };
        }

    }
}

