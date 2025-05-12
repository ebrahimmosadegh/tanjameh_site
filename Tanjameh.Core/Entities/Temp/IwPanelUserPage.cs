using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwPanelUserPage
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string PageName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public bool? TopModify { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwPanelUserPartId { get; set; }

    public virtual IwPanelUserPart IwPanelUserPart { get; set; } = null!;
}
