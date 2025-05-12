using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Tanjameh.Core.Entities;

public class ProductCategory
{
    public ProductCategory()
    {
    }
    private ILazyLoader LazyLoader { get; set; }
    private ProductCategory(ILazyLoader lazyLoader)
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

    public int CategoryId { get; set; }
    private Category _category;
    public Category Category
    {
        get => LazyLoader?.Load(this, ref _category) ?? (_category ??= new Category());
        set => _category = value;
    }


}
