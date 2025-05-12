using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanjameh.Core.Entities;

public class Category
{
    public Category()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private Category(ILazyLoader lazyLoader)
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

    private Category? _parentCategory;
    public Category? ParentCategory
    {
        get => LazyLoader?.Load(this, ref _parentCategory);
        set => _parentCategory = value;
    }


    private IList<Category>? _subCategories;

    [JsonIgnore]
    public IList<Category>? SubCategories
    {
        get
        {
            try
            {
                return LazyLoader?.Load(this, ref _subCategories) ?? (_subCategories ??= new List<Category>());
            }
            catch (Exception)
            {
                return new List<Category>();
            }
        }
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


    public int? WeightId { get; set; }

    //todo check it
    public List<SiteCategoryToApi>? SiteCategoryToApis { get; set; }

    public string Url => $"{GenderType}/{Slug}";

    [NotMapped]
    public bool Mark { get; set; }

    public string DisplayText => $"{Name} - {GenderType.ToString()}";
}
