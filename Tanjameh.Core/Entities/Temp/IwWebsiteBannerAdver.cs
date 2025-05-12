namespace Tanjameh.Core.Entities.Temp;

public partial class IwWebsiteBannerAdver
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string IdKey { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string ConditionStatement { get; set; } = null!;

    public string BottomCaption { get; set; } = null!;

    public string BottomLink { get; set; } = null!;

    public string MainColor { get; set; } = null!;

    public string SecondColor { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwWebsitePagesPartId { get; set; }

    public virtual IwWebsitePagesPart IwWebsitePagesPart { get; set; } = null!;
}
