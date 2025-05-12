using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwTicketsSender
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<IwTicket> IwTickets { get; set; } = new List<IwTicket>();

    public virtual ICollection<IwTicketsReply> IwTicketsReplies { get; set; } = new List<IwTicketsReply>();
}
