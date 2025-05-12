namespace Tanjameh.Features.Favorite.Models;



public class FavoriteModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public long? UserId { get; set; }
    public ICollection<FavoriteItem> Items { get; set; } = new List<FavoriteItem>();
}

public class FavoriteItem
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int? ProductVariantId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public DateTime AddedTime { get; set; }
    public string? ProductThumbnailUrl { get; set; }
    
    public string? ProductUrl { get; set; }
}
