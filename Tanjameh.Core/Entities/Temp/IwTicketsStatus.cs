using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwTicketsStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public virtual ICollection<IwTicket> IwTickets { get; set; } = new List<IwTicket>();
}
