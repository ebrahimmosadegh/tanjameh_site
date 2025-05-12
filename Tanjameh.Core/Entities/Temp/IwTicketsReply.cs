using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwTicketsReply
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwTicketsId { get; set; }

    public int IwTicketsSenderId { get; set; }

    public int? MemberId { get; set; }

    public virtual IwTicketsSender IwTicketsSender { get; set; } = null!;
}
