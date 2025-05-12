using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwCompany
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCountryId { get; set; }

    public virtual ICollection<IwApiAllCat> IwApiAllCats { get; set; } = new List<IwApiAllCat>();

    public virtual ICollection<IwApiProduct> IwApiProducts { get; set; } = new List<IwApiProduct>();

    public virtual ICollection<IwConnectApi> IwConnectApis { get; set; } = new List<IwConnectApi>();

    public virtual ICollection<IwConnectSm> IwConnectSms { get; set; } = new List<IwConnectSm>();

    public virtual IwCountry IwCountry { get; set; } = null!;

    public virtual ICollection<IwNewMenu2> IwNewMenu2s { get; set; } = new List<IwNewMenu2>();

    public virtual ICollection<IwNewMenu3> IwNewMenu3s { get; set; } = new List<IwNewMenu3>();

    public virtual ICollection<IwNewMenu4> IwNewMenu4s { get; set; } = new List<IwNewMenu4>();

    public virtual ICollection<IwProductsDeliveryPrice> IwProductsDeliveryPrices { get; set; } = new List<IwProductsDeliveryPrice>();
}
