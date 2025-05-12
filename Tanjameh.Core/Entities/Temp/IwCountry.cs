using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwCountry
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public virtual ICollection<IwCompany> IwCompanies { get; set; } = new List<IwCompany>();

    public virtual ICollection<IwCurrency> IwCurrencies { get; set; } = new List<IwCurrency>();

    public virtual ICollection<IwUserAddressDetail> IwUserAddressDetails { get; set; } = new List<IwUserAddressDetail>();
}
