

using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class RawProductData
{
    public long Id { get; set; }

    public long? ApiProductId { get; set; }

    public string RawDetailData { get; set; } = string.Empty;

    public string RawListData { get; set; } = string.Empty;

    public string? ApiCategoryIds { get; set; }

    [StringLength(50)]
    public string ApiName { get; set; } = string.Empty;
}
