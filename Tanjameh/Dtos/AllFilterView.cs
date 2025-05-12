using Tanjameh.Core.Constants;

namespace Tanjameh.Dtos;


public class AllFilterView
{
    public List<ColorFilterView> Color { get; set; } = new List<ColorFilterView>();
    public List<BrandFilterView> Brand { get; set; } = new List<BrandFilterView>();
    public PriceFilterView Price { get; set; } = new PriceFilterView(0, 0, 1);
}

public class ColorFilterView(string ColorName, int Count)
{
    public string ColorName { get; set; } = ColorName;
    public string Color => ColorMap.GetColor(ColorName);
    public int Count { get; set; } = Count;

    public bool Selected { get; set; }

}


public record PriceFilterView(decimal MinPrice, decimal MaxPrice, int CurrencyId);

public record BrandFilterView(string BrandName, int BrandId, int Count)
{
    public bool Selected { get; set; }

    public int Count { get; set; } = Count;
};

public class ProductFiltersDto
{
    public string[]? Colors { get; set; }

    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
    public bool HasPriceFilter { get; set; }
    public int? CurrencyId { get; set; }

    public int[]? Brands { get; set; }

    public ProductsOrderBy OrderBy { get; set; } = ProductsOrderBy.Default;

}

public enum ProductsOrderBy
{
    Default,
    New,
    PriceAscending,
    PriceDescending,
    Popular,
    Sale
}
