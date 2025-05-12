using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.JSInterop;
using Tanjameh.Core.Helper;
using Tanjameh.Dtos;
using Tanjameh.Features.Product.Queries;

namespace Tanjameh.Features.Product.Pages;

public partial class ProductsPaging: IDisposable
{
    private CancellationTokenSource _cts = new();

    [Inject]
    public IMediator Mediator { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private bool firstInit = true;

    [Parameter]
    public string? MenCategorySlug { get; set; }

    [Parameter]
    public string? WomenCategorySlgu { get; set; }

    [Parameter]
    public string? SaleSlgu { get; set; }

    [Parameter]
    public string? BrandSlug { get; set; }

    [Parameter]
    public string? ProductTypeSlug { get; set; }

    private string? _genderKey;
    [Parameter]
    [SupplyParameterFromQuery(Name = "gender")]
    public string? GenderKey
    {
        get => _genderKey;
        set
        {
            _genderKey = value;
            if (Enum.TryParse(typeof(Core.Entities.GenderType), _genderKey, true, out var gender))
            {
                _qsGenderType = (Core.Entities.GenderType)gender;
            }
        }
    }
    private Core.Entities.GenderType _qsGenderType = Core.Entities.GenderType.None;

    private string? _searchKey;
    [Parameter]
    [SupplyParameterFromQuery(Name = "q")]
    public string? SearchKey
    {
        get => _searchKey;
        set
        {
            bool keyChanged = !string.IsNullOrEmpty(_searchKey) && value != _searchKey;
            _searchKey = value;
            if (keyChanged)
                GetProducts(true);
        }
    }


    private int? _pageNumber = null;

    [SupplyParameterFromQuery(Name = "page")]
    [Parameter]
    public int? PageNumber { get; set; }


    private string PageSlug = string.Empty;

    private ProductPageType ProductPageType { get; set; } = ProductPageType.None;

    private ProductsDto? ProductsView { get; set; } = null;

    private AllFilterView FilterView { get; set; } = new AllFilterView();

    private ProductFiltersDto? Filters { get; set; } = null;


    public string Title = string.Empty;


    protected async override Task OnInitializedAsync()
    {
        SetPageType();

        try
        {
            await GetProducts();
        }
        catch (ArgumentException)
        {
            NavigationManager.NavigateTo("/404", true);
        }


        firstInit = false;
    }

    private async void UpdateUrlAndGetProducts(int? newPage)
    {
        var uri = NavigationManager.GetUriWithQueryParameter("page", newPage);
        NavigationManager.NavigateTo(uri);
    }

    protected override async Task OnParametersSetAsync()
    {
        if (!firstInit)
        {
            await GetProducts(true);
        }
    }

    public void NextPage()
    {
        if ((PageNumber ?? 1) >= ProductsView?.TotalPages)
            return;

        int newPage = (PageNumber ?? 1) + 1;
        UpdateUrlAndGetProducts(newPage);
    }

    public  void PreviousPage()
    {
        if (PageNumber == null || PageNumber <= 1)
            return;

        int? newPage = PageNumber == 2 ? null : (int?)PageNumber - 1;
        UpdateUrlAndGetProducts(newPage);
    }

    private async Task GetProducts(bool forceUpdate = false, bool updateFilterViewCountOnly = false)
    {

        if (ProductPageType is ProductPageType.Men or ProductPageType.Women)
        {
            ProductsView = await Mediator.Send(
                new CategoryProductsQuery((Core.Entities.GenderType)ProductPageType, PageSlug, new PagingRequest(PageNumber ?? 1), Filters), _cts.Token);
        }
        else if (ProductPageType is ProductPageType.Brand)
        {
            ProductsView = await Mediator.Send(
                  new BrandProductsQuery(_qsGenderType, PageSlug, new PagingRequest(PageNumber ?? 1), Filters), _cts.Token);
        }
        else if (ProductPageType is ProductPageType.ProductType)
        {
            ProductsView = await Mediator.Send(
                  new TypeProductsQuery(_qsGenderType, PageSlug, new PagingRequest(PageNumber ?? 1), Filters), _cts.Token);
        }
        else if (ProductPageType is ProductPageType.Search && SearchKey is not null)
        {
            ProductsView = await Mediator.Send(
                 new SearchProductsQuery(SearchKey, new PagingRequest(PageNumber ?? 1), Filters), _cts.Token);

        }
        else if (ProductPageType is ProductPageType.Sale)
        {
            Core.Entities.GenderType gender = SaleSlgu.ToLower() == Core.Entities.GenderType.Men.ToString().ToLower() ? Core.Entities.GenderType.Men : Core.Entities.GenderType.Women;
            ProductsView = await Mediator.Send(
                  new SaleProductsQuery(gender, new PagingRequest(PageNumber ?? 1), Filters), _cts.Token);
        }

        if (ProductsView is not null)
        {
            Title = ProductsView.Titles;

            if (updateFilterViewCountOnly == false)
            {
                FilterView = ProductsView.FilterView;
            }
            else
            {
                UpdateColorCount(ProductsView);
                UpdateBrandCount(ProductsView);
            }

            OrderFilters();
        }


        if (forceUpdate)
            StateHasChanged();
    }

    private void UpdateColorCount(ProductsDto productsView)
    {
        foreach (var color in FilterView.Color)
        {
            var existColor = productsView.FilterView.Color.FirstOrDefault(x => x.ColorName == color.ColorName);

            if (existColor != null)
            {
                color.Count = existColor.Count;
            }
            else
            {
                color.Count = 0;
            }
        }

    }

    private void UpdateBrandCount(ProductsDto productsView)
    {
        foreach (var brand in FilterView.Brand)
        {
            var existBrand = productsView.FilterView.Brand.FirstOrDefault(x => x.BrandId == brand.BrandId);

            if (existBrand != null)
            {
                brand.Count = existBrand.Count;
            }
            else
            {
                brand.Count = 0;
            }
        }
    }

    private void OrderFilters()
    {
        FilterView.Color = FilterView.Color.OrderByDescending(x => x.Count).ToList();
        FilterView.Brand = FilterView.Brand.OrderByDescending(x => x.Count).ToList();
    }

    private void SetPageType()
    {
        if (!string.IsNullOrEmpty(MenCategorySlug))
        {
            ProductPageType = ProductPageType.Men;
            PageSlug = MenCategorySlug;
            return;
        }
        if (!string.IsNullOrEmpty(WomenCategorySlgu))
        {
            ProductPageType = ProductPageType.Women;
            PageSlug = WomenCategorySlgu;
            return;
        }
        if (!string.IsNullOrEmpty(SaleSlgu))
        {
            ProductPageType = ProductPageType.Sale;
            PageSlug = SaleSlgu;
            return;
        }
        if (!string.IsNullOrEmpty(BrandSlug))
        {
            ProductPageType = ProductPageType.Brand;
            PageSlug = BrandSlug;
            return;
        }
        if (!string.IsNullOrEmpty(ProductTypeSlug))
        {
            ProductPageType = ProductPageType.ProductType;
            PageSlug = ProductTypeSlug;
            return;
        }

        if (!string.IsNullOrEmpty(SearchKey))
        {
            ProductPageType = ProductPageType.Search;
            return;
        }
    }


    private async Task ApplyFilters(ProductFiltersDto filters)
    {
        //todo check filter changes

        Filters = filters;
        await GetProducts(true, true);
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("initializeMenu");
    }

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }
}


public enum ProductPageType
{
    None = 0,
    Women = 1,
    Men = 2,
    Sale,
    Brand,
    ProductType,
    Search
}