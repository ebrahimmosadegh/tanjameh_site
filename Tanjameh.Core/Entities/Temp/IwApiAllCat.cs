using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwApiAllCat
{
    public uint Id { get; set; }

    public int Enabled { get; set; }

    public string Address { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string? Main { get; set; }

    public string Sub { get; set; } = null!;

    public string? Sub2 { get; set; }

    public string? Sub3 { get; set; }

    public string? Sub4 { get; set; }

    public string Title { get; set; } = null!;

    public string TypeSet { get; set; } = null!;

    public int CreateCad { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwCompanyId { get; set; }

    public virtual IwCompany IwCompany { get; set; } = null!;
}
