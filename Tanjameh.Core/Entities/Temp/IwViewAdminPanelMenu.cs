using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwViewAdminPanelMenu
{
    public int PartId { get; set; }

    public string PartName { get; set; } = null!;

    public string PartPname { get; set; } = null!;

    public string PartFaIcon { get; set; } = null!;

    public int PageId { get; set; }

    public int PagePartId { get; set; }

    public string PageName { get; set; } = null!;

    public string PagePname { get; set; } = null!;
}
