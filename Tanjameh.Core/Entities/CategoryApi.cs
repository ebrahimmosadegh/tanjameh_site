using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanjameh.Core.Entities;

public class CategoryApi
{
    public CategoryApi()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private CategoryApi(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    public int Id { get; init; }
    /// <summary>
    /// Gets or sets the name
    /// </summary>
    [StringLength(200)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    [StringLength(500)]
    public string? Description { get; set; }


    [StringLength(110)]
    public string? Slug { get; set; }

    /// <summary>
    /// Gets or sets the parent category identifier
    /// </summary>
    public int? ParentCategoryId { get; set; }

    private CategoryApi? _parentCategory;
    public CategoryApi ParentCategory
    {
        get => LazyLoader?.Load(this, ref _parentCategory) ?? (_parentCategory ??= new CategoryApi());
        set => _parentCategory = value;
    }


    private IList<CategoryApi>? _subCategories;

    [JsonIgnore]
    public IList<CategoryApi>? SubCategories
    {
        get => LazyLoader?.Load(this, ref _subCategories) ?? (_subCategories ??= new List<CategoryApi>());
        set => _subCategories = value;
    }


    public int? GenderTypeId { get; set; }

    [NotMapped]
    public GenderType? GenderType
    {
        get => (GenderType?)GenderTypeId;
        set => GenderTypeId = (int?)value;
    }

    [StringLength(255)]
    public string? MainPictureFileName { get; set; }

    public bool HasPreviewPicture { get; set; }

    public long? ApiId { get; set; }

    [StringLength(50)]
    public string ApiName { get; set; } = string.Empty;


    [StringLength(400)]
    public string? FullPath { get; set; }


    //todo check it
    public List<SiteCategoryToApi>? SiteCategoryToApis { get; set; }


    public string DisplayText => $"{Name} - {FullPath?.Replace("https://www.asos.com/", "") ?? "none"}";
}
