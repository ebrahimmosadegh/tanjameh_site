using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwTicket
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Subject { get; set; } = null!;

    public string? Message { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwTicketsCategoriesId { get; set; }

    public int IwTicketsSenderId { get; set; }

    public int MemberId { get; set; }

    public int IwTicketsStatusId { get; set; }

    public int IwTicketsPrioritiesId { get; set; }

    public virtual IwTicketsCategory IwTicketsCategories { get; set; } = null!;

    public virtual IwTicketsPriority IwTicketsPriorities { get; set; } = null!;

    public virtual IwTicketsSender IwTicketsSender { get; set; } = null!;

    public virtual IwTicketsStatus IwTicketsStatus { get; set; } = null!;
}
