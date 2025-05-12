using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwWeightCountry
{
    public int Id { get; set; }

    public int? IwCountryId1 { get; set; }

    public int? IwCountryId2 { get; set; }

    public int Internal { get; set; }

    public int Free { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public virtual ICollection<IwProductsWeightPrice> IwProductsWeightPrices { get; set; } = new List<IwProductsWeightPrice>();
}
