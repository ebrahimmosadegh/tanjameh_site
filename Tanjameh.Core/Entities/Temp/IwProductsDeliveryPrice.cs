using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductsDeliveryPrice
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public int Smaller { get; set; }

    public int Bigger { get; set; }

    public float ChangeRate { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCompanyId { get; set; }

    public virtual IwCompany IwCompany { get; set; } = null!;
}
