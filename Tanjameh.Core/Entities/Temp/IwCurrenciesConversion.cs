using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwCurrenciesConversion
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public float Rate { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCurrenciesId1 { get; set; }

    public int IwCurrenciesId2 { get; set; }

    public virtual ICollection<IwProductsPrice> IwProductsPrices { get; set; } = new List<IwProductsPrice>();
}
