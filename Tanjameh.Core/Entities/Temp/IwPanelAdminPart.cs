using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwPanelAdminPart
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; } = null!;

    public string PartName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string FaIcon { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public virtual ICollection<IwPanelAdminPage> IwPanelAdminPages { get; set; } = new List<IwPanelAdminPage>();
}
