using System.Text.Json.Serialization;

namespace Tanjameh.BackgroundServices.ViewModel;


public class AsosApiProductListResponse
{
    public string? SearchTerm { get; set; }
    public string? CategoryName { get; set; }
    public int ItemCount { get; set; }
    public string? RedirectUrl { get; set; }
    public List<AsosApiProduct>? Products { get; set; }
    public List<Facet>? Facets { get; set; }
    public Diagnostics? Diagnostics { get; set; }
    public SearchPassMeta? SearchPassMeta { get; set; }
    public string? QueryId { get; set; }
    public List<string>? DiscoverSearchProductTypes { get; set; }
    //public Campaigns? Campaigns { get; set; }
}

public class AsosApiProduct
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public Price? Price { get; set; }
    public string? Colour { get; set; }
    public int? ColourWayId { get; set; }
    public string? BrandName { get; set; }
    public bool HasVariantColours { get; set; }
    public bool HasMultiplePrices { get; set; }
    //public int? GroupId { get; set; }
    public long? ProductCode { get; set; }
    public string? ProductType { get; set; }
    public string? Url { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? AdditionalImageUrls { get; set; }
    public string? VideoUrl { get; set; }
    public bool ShowVideo { get; set; }
    public bool IsSellingFast { get; set; }
    public bool IsRestockingSoon { get; set; }
    public bool IsPromotion { get; set; }
    //public int? SponsoredCampaignId { get; set; }
    public List<FacetGrouping>? FacetGroupings { get; set; }
    //public object Advertisement { get; set; }

    [JsonIgnore]
    public long? ApiCategoryId { get; set; }
    public int? ApiCategoryGenderTypeId { get; set; }
}

public class Price
{
    public CurrentPrice? Current { get; set; }
    public PreviousPrice? Previous { get; set; }
    public RrpPrice? Rrp { get; set; }
    public bool IsMarkedDown { get; set; }
    public bool IsOutletPrice { get; set; }
    public string? Currency { get; set; }
}

public class FacetGrouping
{
    public List<AsosApiProduct>? Products { get; set; }
    public string? Type { get; set; }
}

public class CurrentPrice
{
    public decimal Value { get; set; }
    public string? Text { get; set; }
}

public class PreviousPrice
{
    public decimal? Value { get; set; }
    public string? Text { get; set; }
}

public class RrpPrice
{
    public decimal? Value { get; set; }
    public string? Text { get; set; }
}

public class Facet
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public List<FacetValue>? FacetValues { get; set; }
    public string? DisplayStyle { get; set; }
    public string? FacetType { get; set; }
    public bool HasSelectedValues { get; set; }
}

public class FacetValue
{
    public int Count { get; set; }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public bool IsSelected { get; set; }
}

public class Diagnostics
{
    public string? RequestId { get; set; }
    public int ProcessingTime { get; set; }
    public int QueryTime { get; set; }
    public bool RecommendationsEnabled { get; set; }
    public RecommendationsAnalytics? RecommendationsAnalytics { get; set; }
    public bool AdvertisementsEnabled { get; set; }
    public AdvertisementsAnalytics? AdvertisementsAnalytics { get; set; }
    public CurationAnalytics? CurationAnalytics { get; set; }
}

public class RecommendationsAnalytics
{
    public int PersonalisationStatus { get; set; }
    public int NumberOfItems { get; set; }
    public int NumberOfRecs { get; set; }
    public string? PersonalisationType { get; set; }
    public string? ExperimentTrackerkey { get; set; }
    //public List<object>? Items { get; set; }
}

public class AdvertisementsAnalytics
{
    public int Status { get; set; }
    public bool CustomerOptIn { get; set; }
    public int NumberOfItemsFromPartner { get; set; }
    //public List<object>? Items { get; set; }
    //public List<object>? ItemsFromPartner { get; set; }
    //public PlacementBeacons? PlacementBeacons { get; set; }
}

//public class PlacementBeacons
//{
//    public object OnLoadBeacon { get; set; }
//    public object OnViewBeacon { get; set; }
//}

public class CurationAnalytics
{
    public int Status { get; set; }
    public int NumberOfCuratedItems { get; set; }
    //public List<object>? ElevatedItems { get; set; }
    //public List<object>? FixedItems { get; set; }
    //public List<object>? ComingSoonItems { get; set; }
    //public List<object>? AdvertisementPositions { get; set; }
    //public List<object>? MarketingItems { get; set; }
}

public class SearchPassMeta
{
    public bool IsPartial { get; set; }
    public bool IsSpellcheck { get; set; }
    //public List<object>? SearchPass { get; set; }
    //public List<object>? AlternateSearchTerms { get; set; }
}

//public class Campaigns
//{
//    public List<object>? ImageTiles { get; set; }
//    public List<object>? PromoBanners { get; set; }
//    public List<object>? SponsoredProducts { get; set; }
//}