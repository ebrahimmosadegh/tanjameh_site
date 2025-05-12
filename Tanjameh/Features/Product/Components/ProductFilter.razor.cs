using MediatR;
using Microsoft.AspNetCore.Components;
using Tanjameh.Dtos;


namespace Tanjameh.Features.Product.Components;

public partial class ProductFilter
{
    private IEnumerable<decimal> _selectedPriceRange = [0, 0];

    [Inject]
    public IMediator Mediator { get; set; }


    [Parameter]
    public AllFilterView AllFilterView { get; set; } = new AllFilterView();


    [Parameter]
    public EventCallback<ProductFiltersDto> ApplyFilters { get; set; }



    private IEnumerable<decimal> SelectedPriceRange
    {
        get => _selectedPriceRange;
        set
        {
            _selectedPriceRange = value;

            if (value.First() != AllFilterView.Price.MinPrice || value.Last() != AllFilterView.Price.MaxPrice)
                HasPriceFilter = true;
        }
    }
    private bool HasPriceFilter { get; set; }

    private ProductsOrderBy ProductsOrderBy { get; set; }

    protected async override Task OnInitializedAsync()
    {
        SetDefaultPriceRange();
    }


    private async void Apply()
    {
        var model = new ProductFiltersDto();

        model.Colors = AllFilterView.Color.Where(x => x.Selected).Select(x => x.ColorName).ToArray();
        model.Brands = AllFilterView.Brand.Where(x => x.Selected).Select(x => x.BrandId).ToArray();


        if (SelectedPriceRange.First() > 0)
        {
            model.MinPrice = SelectedPriceRange.First();
        }
        if (SelectedPriceRange.Last() > 0)
        {
            model.MaxPrice = SelectedPriceRange.Last();
        }

        model.HasPriceFilter = HasPriceFilter;

        model.OrderBy = ProductsOrderBy;

        await ApplyFilters.InvokeAsync(model);
    }

    private void OrderBy(ProductsOrderBy orderBy)
    {
        ProductsOrderBy = orderBy;

        Apply();
    }


    private void ClearColors()
    {
        bool applyFillter = AllFilterView.Color.Any(x => x.Selected);
        foreach (var item in AllFilterView.Color)
        {
            item.Selected = false;
        }

        if (applyFillter)
            Apply();
    }

    private void ClearBrands()
    {
        bool applyFillter = AllFilterView.Brand.Any(x => x.Selected);
        foreach (var item in AllFilterView.Brand)
        {
            item.Selected = false;
        }


        if (applyFillter)
            Apply();
    }

    private void ClearPrice()
    {
        SetDefaultPriceRange();
        Apply();
    }

    private void SetDefaultPriceRange()
    {
        SelectedPriceRange = [AllFilterView.Price.MinPrice, AllFilterView.Price.MaxPrice];
    }


}
