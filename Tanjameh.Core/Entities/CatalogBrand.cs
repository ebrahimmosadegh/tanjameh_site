using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class CatalogBrand
{
    public int Id { get; init; }

    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    [StringLength(900)]
    public string Description { get; set; } = string.Empty;

    [StringLength(255)]
    public string LogoFileName { get; set; } = string.Empty;

    [StringLength(2083)]
    public string? LogoUrl { get; set; }

    [StringLength(2083)]
    public string? HomeUrl { get; set; }

    [StringLength(50)]
    public string? OgType { get; set; }

    [StringLength(200)]
    public string? Slug { get; set; }


    public long? ApiId { get; set; }

    public ICollection<CatalogBrandApi> CatalogBrandApis { get; set; } = new HashSet<CatalogBrandApi>();

    public DateTime? UpdatedOnUtc { get; set; }

    public string Url => $"brand/{Slug}";
}


public class CatalogBrandApi
{
    public int Id { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    public DateTime? LastModify { get; set; }

    public long? ApiId { get; set; }

    [StringLength(50)]
    public string ApiName { get; set; } = string.Empty;

    public int CatalogBrandId { get; set; }
    public CatalogBrand CatalogBrand { get; set; }

}


