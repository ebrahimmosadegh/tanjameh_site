namespace Tanjameh.BackgroundServices.ViewModel;

public class AsosCategoryResponse
{
    public List<MenuItem> Navigation { get; set; }
}

public class MenuItem
{
    public string Id { get; set; }

    public string? Alias { get; set; }

    public int WebLargePriority { get; set; }

    public MenuItemContent? Content { get; set; }

    //skip Display

    public MenuItemLink? Link { get; set; }

    public List<MenuItem> Children { get; set; }

}

public class MenuItemContent
{
    public string Title { get; set; } = string.Empty;

    public string? SubTitle { get; set; }

    public string? WebLargeImageUrl { get; set; }
    public string? MobileImageUrl { get; set; }
}

public class MenuItemLink
{
    public string? LinkType { get; set; } //category

    public string? BrandSectionAlias { get; set; }

    public int? CategoryId { get; set; }

    public string? WebUrl { get; set; } //https://www.asos.com/men/ctas/coded-promos/promo-8/cat/?cid=50062
}
