using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class CatIdList
{
    public int CatId { get; set; }

    public int CountAll { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public int Id { get; set; }

    public string ListProducts { get; set; } = null!;
}
