using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwPanelAdminPage
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string PageName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public bool? TopModify { get; set; }

    public string Description { get; set; } = null!;

    public int IwPanelAdminPartId { get; set; }

    public virtual IwPanelAdminPart IwPanelAdminPart { get; set; } = null!;
}
