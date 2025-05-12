using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductsWeightPrice
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public float? NormalPrice { get; set; }

    public float? ExtraPrice { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwWeightCountryId { get; set; }

    public int IwProductWeightId { get; set; }

    public virtual ICollection<IwNewMenu> IwNewMenus { get; set; } = new List<IwNewMenu>();

    public virtual IwProductWeight IwProductWeight { get; set; } = null!;

    public virtual IwWeightCountry IwWeightCountry { get; set; } = null!;
}
