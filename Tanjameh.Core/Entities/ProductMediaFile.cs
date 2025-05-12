using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Tanjameh.Core.Entities;

public partial class ProductMediaFile
{
    public int Id { get; init; }

    public ProductMediaFile()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductMediaFile(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    /// <summary>
    /// Gets or sets the product identifier.
    /// </summary>
    public int ProductId { get; set; }

    private Product? _product;
    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    public Product Product
    {
        get => _product ?? LazyLoader.Load(this, ref _product)!;
        set => _product = value;
    }

    /// <inheritdoc/>
    //public int MediaFileId { get; set; }

    private MediaFile? _mediaFile;
    /// <inheritdoc/>
    public MediaFile? MediaFile
    {
        get => _mediaFile ?? LazyLoader.Load(this, ref _mediaFile);
        set => _mediaFile = value;
    }

    /// <inheritdoc/>
    //public int MediaFileId { get; set; }

    private MediaFile? _thumbnailFile;

    /// <inheritdoc/>
    public MediaFile? ThumbnailFile
    {
        get => _thumbnailFile ?? LazyLoader.Load(this, ref _thumbnailFile);
        set => _thumbnailFile = value;
    }

    /// <inheritdoc/>
    public int DisplayOrder { get; set; }

    public int ProductVarientId { get; set; }

    public string? TypeHelp { get; set; }

    [NotMapped]
    public bool Hidden
    {
        get { return MediaFile?.Hidden ?? false; }
        set
        {
            if (MediaFile != null)
                MediaFile.Hidden = value;
            if (ThumbnailFile != null)
                ThumbnailFile.Hidden = value;
        }
    }
}

