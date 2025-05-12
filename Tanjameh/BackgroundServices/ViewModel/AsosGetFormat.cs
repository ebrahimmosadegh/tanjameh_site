namespace Tanjameh.BackgroundServices.ViewModel;

public class AsosGetFormat
{
    public AsosApiType AsosApiType = AsosApiType.ProductList;
    public Dictionary<string, string>? AdditionalFilters;
    public string? AdditionalQueryString;
    public long? CategoryId;
    public int Skip;
    public int Take;
    public int IterateCount;

    public DateOnly? StartDate;
}

public enum AsosApiType
{
    Category,
    ProductList,
    ProductDetail,
    Country,
    Price
}