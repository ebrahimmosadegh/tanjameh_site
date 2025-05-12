
using System.Text.Json.Serialization;

namespace Tanjameh.Core.Entities;

public class WeightSource
{
    public int Id { get; set; }

    public float Weight { get; set; }

    public ProductWeightPrice? ProductWeightPrice { get; set; }
}


public class ProductWeightPrice
{
    public int Id { get; set; }

    public int WeightId { get; set; }
    [JsonIgnore]
    public WeightSource Weight { get; set; } = default!;

    public int? CurrencyId { get; set; }
    [JsonIgnore]
    public Currency? Currency { get; set; }

    public decimal NormalPrice { get; set; }

    public decimal ExtraPrice { get; set; }

    //public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOnUtc { get; set; }
}