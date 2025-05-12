using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwNewMenu
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string? LocalName { get; set; }

    public string? Icon { get; set; }

    public string? LinkTo { get; set; }

    public string? Description { get; set; }

    public int FromApi { get; set; }

    public string? ApiId { get; set; }

    public int IwProductWeightId { get; set; }

    public virtual ICollection<IwNewMenu2> IwNewMenu2s { get; set; } = new List<IwNewMenu2>();

    public virtual IwProductsWeightPrice IwProductWeight { get; set; } = null!;
}
