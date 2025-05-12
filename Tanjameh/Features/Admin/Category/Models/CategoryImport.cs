namespace Tanjameh.Features.Admin.Category.Models;

public class CategoryImport
{
    public int? Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string Slug { get; set; } = string.Empty;

    public int GenderId { get;  set; }

    public List<CategoryImport>? SubCategories { get; set; }
}
