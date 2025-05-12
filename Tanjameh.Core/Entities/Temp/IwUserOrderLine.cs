using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserOrderLine
{
    public int Id { get; set; }

    public int Qty { get; set; }

    public float? Price { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwApiProductVariantsId { get; set; }

    public virtual IwApiProductVariant IwApiProductVariants { get; set; } = null!;

    public virtual ICollection<IwUserReview> IwUserReviews { get; set; } = new List<IwUserReview>();
}
