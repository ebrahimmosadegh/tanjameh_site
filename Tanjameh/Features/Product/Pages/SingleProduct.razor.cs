using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tanjameh.Dtos;
using Tanjameh.Features.Product.Queries;
using Tanjameh.Features.ShoppingCart.Services;
using Tanjameh.Core.Interfaces; // Added for IPriceCalculatorService
using Tanjameh.Core.Entities; // Added for WeightSource (already present)
using System.Threading.Tasks; // Added for Task
using System.Linq; // Added for LINQ
using System.Threading; // Added for CancellationToken
using System; // Added for IDisposable

namespace Tanjameh.Features.Product.Pages;

public partial class SingleProduct : IDisposable
{
    private CancellationTokenSource _cts = new();

    [Inject]
    public IMediator Mediator { get; set; } = default!;

    [Inject]
    public IJSRuntime JSRuntime { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    public IShoppingCartService ShoppingCartService { get; set; } = default!;

    [Inject]
    public IPriceCalculatorService PriceCalculatorService { get; set; } = default!; // Added Price Calculator

    [Parameter]
    public string ProductSlug { get; set; } = string.Empty;

    [Parameter]
    public int ProductId { get; set; }

    public ProductDetailsDto? Product { get; set; }
    public ProductWeightPriceDto ProductWeightPrice { get; set; } =
        new ProductWeightPriceDto() { WeightSource = new WeightSource() };

    // ProductInfo seems redundant if Product holds the details
    // public ProductInfoDto ProductInfo { get; set; } = new ProductInfoDto();

    public string ProductName { get; set; } = string.Empty;

    // --- Properties to hold calculated prices ---
    // Assuming ProductDetailsDto and ProductVariantDto are modified to include:
    // public PriceCalculationResult? LocalPriceInfo { get; set; }
    // We will calculate these in GetProduct()

    // Example: Store target currency (could come from user context later)
    private string _targetCurrency = "IRR"; // Default to Toman (IRR)

    public void Dispose()
    {
        _cts.Cancel();
        _cts.Dispose();
    }

    protected override async Task OnInitializedAsync()
    {
        await GetProduct();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Product != null)
        {
            await JSRuntime.InvokeVoidAsync("initializeImageZoom", "img-container", "#img-container img");
        }
    }

    private async Task GetProduct()
    {
        Product = await Mediator.Send(new GetProductQuery(ProductId, ProductSlug), _cts.Token);

        if (Product is null)
        {
            NavigationManager.NavigateTo("/404", true);
            return; // Exit if product not found
        }

        ProductWeightPrice = await Mediator.Send(new ProductWeightPriceQuery(ProductId), _cts.Token);

        if (Product.ProductVariants is not null)
        {
            Product.ProductVariants = Product.ProductVariants.Where(x => !x.IsDefault).ToList();
        }

        ProductName = Product.Name;

        // --- Calculate Local Prices --- 
        // Calculate for the main product price (if displayed/relevant)
        // Assuming Product.Price represents the original GBP price
        // Note: ProductVariantDto likely holds the relevant price now
        // if (Product.Price > 0) {
        //     Product.LocalPriceInfo = await PriceCalculatorService.CalculatePriceAsync(Product.Price, _targetCurrency);
        // }

        // Calculate for each variant
        if (Product.ProductVariants != null)
        {
            foreach (var variant in Product.ProductVariants)
            {
                // Assuming variant.Price holds the original GBP price
                if (variant.Price > 0)
                {
                    // Assuming ProductVariantDto has a LocalPriceInfo property
                    // variant.LocalPriceInfo = await PriceCalculatorService.CalculatePriceAsync(variant.Price, _targetCurrency);
                    
                    // --- Placeholder: Modify DTO directly (Not ideal, DTOs should be immutable) ---
                    // This requires ProductVariantDto to be mutable and have the LocalPriceInfo property.
                    // A better approach would be to create a new ViewModel or use a dictionary.
                    // For now, we assume the DTO can be modified for demonstration.
                    var priceResult = await PriceCalculatorService.CalculatePriceAsync(variant.Price, _targetCurrency);
                    // How to store this? Let's assume we add it to the DTO instance directly.
                    // This assumes ProductVariantDto has a property like: public PriceCalculationResult? LocalPriceInfo { get; set; }
                    // If ProductVariantDto is defined elsewhere, this line won't compile without modification to that DTO.
                    // variant.LocalPriceInfo = priceResult; 
                    
                    // Alternative: Store in a dictionary mapped by VariantId
                    // _variantLocalPrices[variant.Id] = priceResult;
                }
            }
        }
        // --- End Calculate Local Prices ---

        // Ensure StateHasChanged is called if needed after product load
        StateHasChanged();
    }

    // Helper method to display price (example)
    private string DisplayPrice(decimal price, string currencyCode)
    {
        // Add currency formatting logic here (e.g., using CultureInfo)
        // Example for IRR (Toman) - might need specific formatting
        if (currencyCode.Equals("IRR", StringComparison.OrdinalIgnoreCase))
        {
            return $"{price:N0} Toman"; // Format as integer Toman
        }
        return price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo(currencyCode)); // Standard currency format
    }

    // Method to handle adding to cart (might need price context)
    private async Task HandleAddToCart(int variantId)
    {
        // Find the selected variant
        var selectedVariant = Product?.ProductVariants?.FirstOrDefault(v => v.Id == variantId);
        if (selectedVariant == null) return;

        // Use the ShoppingCartService (already injected)
        // The CartController now handles real-time price checks, so we just pass the variant ID.
        await ShoppingCartService.AddToCart(new AddToCartRequestDto { VariantId = variantId, Quantity = 1 });
        
        // Optionally: Show confirmation
        // await JSRuntime.InvokeVoidAsync("alert", $"Added {ProductName} - {selectedVariant.Name} to cart.");
        // Optionally: Update cart indicator in UI
    }
}

// --- Assumed DTO Modifications (These need to be done in the actual DTO files) ---
/*
namespace Tanjameh.Dtos 
{
    // In ProductVariantDto.cs (or similar)
    public class ProductVariantDto 
    {
        // ... existing properties ...
        public decimal Price { get; set; } // Assuming this is original GBP price
        public Tanjameh.Core.Interfaces.PriceCalculationResult? LocalPriceInfo { get; set; } // Added property
    }

    // In ProductDetailsDto.cs (or similar)
    public class ProductDetailsDto
    {
        // ... existing properties ...
        public decimal Price { get; set; } // Assuming this is original GBP price (if applicable)
        public List<ProductVariantDto>? ProductVariants { get; set; }
        public Tanjameh.Core.Interfaces.PriceCalculationResult? LocalPriceInfo { get; set; } // Added property (if main price needed)
    }
}
*/

