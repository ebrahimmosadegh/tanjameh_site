using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUserPaymentType
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public virtual ICollection<IwUserPaymentMethod> IwUserPaymentMethods { get; set; } = new List<IwUserPaymentMethod>();
}
