using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductsPrice
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public float Smaller { get; set; }

    public float Bigger { get; set; }

    public float ChangeRate { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCurrenciesConversionId { get; set; }

    public virtual IwCurrenciesConversion IwCurrenciesConversion { get; set; } = null!;
}
