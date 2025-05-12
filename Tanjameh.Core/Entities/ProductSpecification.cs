using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Tanjameh.Core.Entities;

public class ProductSpecification
{
    public ProductSpecification()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductSpecification(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public int ProductId { get; set; }

    private Product? _product;
    public Product Product
    {
        get => LazyLoader?.Load(this, ref _product) ?? (_product ??= new Product());
        set => _product = value;
    }


    /// <summary>
    /// Gets or sets a value indicating whether the attribute can be filtered.
    /// Only effective in accordance with MegaSearchPlus module.
    /// </summary>
    public bool? AllowFiltering { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the attribute will be shown on the product page.
    /// </summary>
    public bool? ShowOnProductPage { get; set; }

    /// <summary>
    /// Gets or sets the display order.
    /// </summary>
    public int DisplayOrder { get; set; }
}


public class SpecificationOption
{
    public SpecificationOption()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private SpecificationOption(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    public long Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public int ProductSpecificationId { get; set; }

    private ProductSpecification? _productSpecification;

    public ProductSpecification ProductSpecification
    {
        get => LazyLoader?.Load(this, ref _productSpecification) ?? (_productSpecification ??= new ProductSpecification());
        set => _productSpecification = value;
    }

    public string Alias { get; set; }

    /// <summary>
    /// Gets or sets the display order.
    /// </summary>
    public int DisplayOrder { get; set; }

    /// <summary>
    /// Gets or sets the number value for range filtering.
    /// </summary>
    public decimal NumberValue { get; set; }

    /// <summary>
    /// Gets or sets the color RGB value.
    /// </summary>
    [StringLength(100)]
    public string Color { get; set; }

    public long? ApiId { get; set; }

}



