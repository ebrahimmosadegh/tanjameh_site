
using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class EventLog
{
    public long Id { get; set; }

    [StringLength(100)]
    public string Context { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;

    public DateTime TimeInUtc { get; set; }
}
