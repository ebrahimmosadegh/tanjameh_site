using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwPaymentState
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string? ResitId { get; set; }

    public string State { get; set; } = null!;

    public string? Status { get; set; }

    public string Secvl { get; set; } = null!;

    public string? Rrn { get; set; }

    public string? TerminalId { get; set; }

    public string AmountRial { get; set; } = null!;

    public string? Amount { get; set; }

    public string StateCode { get; set; } = null!;

    public string ResNum { get; set; } = null!;

    public string? Mid { get; set; }

    public string RefNum { get; set; } = null!;

    public string? Cid { get; set; }

    public string? TraceNo { get; set; }

    public string? SecurePan { get; set; }

    public string BankName { get; set; } = null!;

    public string? Wage { get; set; }

    public string? HashedCardNumber { get; set; }

    public string? Token { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime LastModify { get; set; }

    public string ModifyId { get; set; } = null!;

    public string ModifyIp { get; set; } = null!;

    public int IwUserId { get; set; }

    public int IwUserShoppingCartId { get; set; }

    public virtual IwUser IwUser { get; set; } = null!;

    public virtual IwUserShoppingCart IwUserShoppingCart { get; set; } = null!;
}
