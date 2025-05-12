using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;
using Tanjameh.Core.Helper;

namespace Tanjameh.Core.Entities;

public partial class MediaFile : BaseEntity<int>
{
    public string? MediaFolder { get; set; }

    [StringLength(300)]
    public string Name { get; set; }

    [StringLength(400)]
    public string Alt { get; set; } = "";

    [StringLength(400)]
    public string Title { get; set; }= "";

    [StringLength(10)]
    public string Extension { get; set; }

    /// <summary>
    /// Gets or sets the file media type (image, video, audio, document etc.).
    /// </summary>
    [Required, StringLength(20)]
    public string MediaType { get; set; } = "image";


    /// <summary>
    /// Gets or sets the image width (if file is an image).
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Gets or sets the image height (if file is an image).
    /// </summary>
    public int? Height { get; set; }


    /// <summary>
    /// Gets or sets a value indicating whether the file has been soft deleted.
    /// </summary>
    public bool Hidden { get; set; }

    public bool IsThumbnial { get; set; }

     
    public string? WebUrl => MediaFolder.FilePathToUrl(Name);


    //todo Replace All DateTime with CreatedOnUtc, UpdatedOnUtc
}


public static class MediaType{
    public const string Image = "image";
    public const string Video = "video";
    public const string Audio = "audio";
    public const string Document = "document";
    public const string Other = "other";
}