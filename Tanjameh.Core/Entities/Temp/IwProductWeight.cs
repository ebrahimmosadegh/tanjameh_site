using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwProductWeight
{
    public int Id { get; set; }

    public float Weight { get; set; }

    public virtual ICollection<IwNewMenu2> IwNewMenu2s { get; set; } = new List<IwNewMenu2>();

    public virtual ICollection<IwNewMenu3> IwNewMenu3s { get; set; } = new List<IwNewMenu3>();

    public virtual ICollection<IwNewMenu4> IwNewMenu4s { get; set; } = new List<IwNewMenu4>();

    public virtual ICollection<IwProductsWeightPrice> IwProductsWeightPrices { get; set; } = new List<IwProductsWeightPrice>();
}
