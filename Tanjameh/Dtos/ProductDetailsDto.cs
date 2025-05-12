using Tanjameh.Core.Entities;

namespace Tanjameh.Dtos;

public class ProductDetailsDto : ProductInfoDto
{

    public string Content { get; set; } = string.Empty;

    public string ShortDescription { get; set; } = string.Empty;

    public int? Rating { get; set; }

    public long? ApiId { get; set; }

    public bool Exist { get; set; }

    public bool InSale { get; set; }

    public GenderType? GenderType { get; set; }

    public required List<ProductMediaDto> Medias { get; set; }

    public List<ProductVariant>? ProductVariants { get; set; }

    public List<ProductCategoryDto>? ProductCategories { get; set; }

    public ProductTypeDto? ProductType { get; set; }

}



public static class Mapper
{
    public static ProductDetailsDto ToProductDetailsDto(this Product product)
    {
        var model = new ProductDetailsDto
        {
            Id = product.Id,
            Slug = product.Slug,
            Name = product.Name,
            Content = product.Content,
            Price = product.Price,
            OldPrice = product.OldPrice,
            PriceCurrencyId = product.PriceCurrencyId,
            FullDescription = product.FullDescription,
            BrandId = product.CatalogBrand.Id,
            BrandUrl = product.CatalogBrand.Url,
            BrandName = product.CatalogBrand.Name,
            BrandDescription = product.CatalogBrand.Description,
            Medias = product.ProductMediaFiles.Where(x => x.MediaFile != null).Select(x => new ProductMediaDto
            {
                DisplayOrder = x.DisplayOrder,
                WebUrl = x.MediaFile!.WebUrl,
                Alt = x.MediaFile.Alt,
                MediaType = x.MediaFile.MediaType,
                ProductVarientId = x.ProductVarientId,
                Title = x.MediaFile.Title
            }).ToList(),
            GenderType = product.GenderType,
            Exist = product.Exist,
            InSale = product.InSale,
            ApiId = product.ApiId,
            CustomePriceKey = product.CustomePriceKey,
            Rating = product.Rating,
            ShortDescription = product.ShortDescription,
            ProductCategories = product.ProductCategories.Select(x =>
            new ProductCategoryDto { ProductId = x.CategoryId, Name = x.Category.Name, Url = x.Category.Url }).ToList(),
        };

        if (product.ProductType != null)
        {
            model.ProductType = new ProductTypeDto { Name = product.ProductType.Name, ProductTypeId = product.ProductTypeId, Url = product.ProductType.Url };
        }

        if (product.ProductVariants != null)
        {
            model.ProductVariants = product.ProductVariants.ToList();
        }


        return model;
    }
}