using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class Price
{
    public int Id { get; set; }

    public decimal? Value { get; set; }

    public string? Text { get; set; }

    public string? VersionId { get; set; }

    public string? ConversionId { get; set; }

    public string? Currency { get; set; }

    public bool? IsMarkedDown { get; set; }

    public bool? IsOutletPrice { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? PreviousEndDate { get; set; }

    public decimal? LowestPriceInLast30DaysValue { get; set; }

    public string? LowestPriceInLast30DaysText { get; set; }

    public DateTime? LowestPriceInLast30DaysEndDate { get; set; }

    public decimal? LowestPriceInLast30DaysPercentage { get; set; }

    public DateTime? WasPriceStartDate { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public virtual IwProduct? Product { get; set; }
}
