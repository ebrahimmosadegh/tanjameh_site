using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserAddressDetail
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string NicName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? OtherTel { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCountryId { get; set; }

    public string City { get; set; } = null!;

    public string? Name { get; set; }

    public string? Family { get; set; }

    public string? Gender { get; set; }

    public virtual IwCountry IwCountry { get; set; } = null!;

    public virtual ICollection<IwUserShopOrder> IwUserShopOrders { get; set; } = new List<IwUserShopOrder>();
}
