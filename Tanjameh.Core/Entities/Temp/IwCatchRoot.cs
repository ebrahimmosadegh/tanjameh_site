using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwCatchRoot
{
    public int Id { get; set; }

    public int RootId { get; set; }

    public int Counter { get; set; }

    public string? LastUpdatedDate { get; set; }

    public string? Name { get; set; }

    public int? Root { get; set; }

    public int? TotalProduct { get; set; }
}
