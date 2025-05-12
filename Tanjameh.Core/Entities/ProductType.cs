using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using Tanjameh.Core.Abstractions;

namespace Tanjameh.Core.Entities;

public class ProductType 
{
    public int Id { get; set; }

    public ProductType()
    {

    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductType(ILazyLoader lazyLoader)
    {
        LazyLoader = lazyLoader;
    }

    [StringLength(255)]
    public string Name { get; set; } = string.Empty;

    public int? WeightId { get; set; }

    public long? ApiId { get; set; }


    private ICollection<Product>? _products;
    public ICollection<Product>? Products
    {
        get => LazyLoader?.Load(this, ref _products) ?? (_products ??= new HashSet<Product>());
        set => _products = value;
    }

    //todo update slug by db
    [StringLength(100)]
    public string? Slug { get; set; }

    public DateTime? UpdatedOnUtc { get; set; }

    // public string Url => $"product-type/{Slug}";
    public string Url => $"trend/{Slug}";

}


