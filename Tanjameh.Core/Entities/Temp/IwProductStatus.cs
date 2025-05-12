using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductStatus
{
    public int Pview { get; set; }

    public int Pbuy { get; set; }

    public int Pscore { get; set; }

    public uint IwApiProductsId { get; set; }

    public virtual IwApiProduct IwApiProducts { get; set; } = null!;
}
