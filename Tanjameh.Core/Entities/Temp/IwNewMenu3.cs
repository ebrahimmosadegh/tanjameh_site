using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwNewMenu3
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

    public string CatId { get; set; } = null!;

    public int CreateCad { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwCompanyId { get; set; }

    public int IwProductWeightId { get; set; }

    public int IwNewMenu2Id { get; set; }

    public virtual IwCompany IwCompany { get; set; } = null!;

    public virtual IwNewMenu2 IwNewMenu2 { get; set; } = null!;

    public virtual ICollection<IwNewMenu4> IwNewMenu4s { get; set; } = new List<IwNewMenu4>();

    public virtual IwProductWeight IwProductWeight { get; set; } = null!;
}
