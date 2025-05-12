using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserReview
{
    public int Id { get; set; }

    public float RatingValue { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserId { get; set; }

    public int IwUserOrderLineId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserOrderLine IwUserOrderLine { get; set; } = null!;
}
