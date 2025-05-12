using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class SiteCategoryToApi : BaseEntity<long>
{
    public int SiteCategoryId { get; set; }

    public int ApiCategoryId { get; set; }

    public Category SiteCategory { get; set; } = null!;

    public CategoryApi ApiCategory { get; set; } = null!;

}
