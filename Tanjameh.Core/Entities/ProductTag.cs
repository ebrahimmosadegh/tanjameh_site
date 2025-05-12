using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Tanjameh.Core.Entities;

public class ProductTag
{
    public int Id { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = string.Empty;
}



public class ProductProductTag
{

    public ProductProductTag()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductProductTag(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    public int ProductId { get; set; }

    private Product _product;
    public Product Product
    {
        get => LazyLoader?.Load(this, ref _product) ?? (_product ??= new Product());
        set => _product = value;
    }

    public int? ProductTagId { get; set; }
    private ProductTag? _productTag;
    public ProductTag? ProductTag
    {
        get => LazyLoader?.Load(this, ref _productTag) ?? (_productTag ??= new ProductTag());
        set => _productTag = value;
    }

    public long? ApiId { get; set; }
}


