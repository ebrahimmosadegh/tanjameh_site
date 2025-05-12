using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Tanjameh.Core.Entities;
using Tanjameh.Features.Admin.Media.Services;
using Tanjameh.Features.Admin.Media.Model;
using System.Linq.Dynamic.Core;
using Tanjameh.Core.Enums;
using Tanjameh.Dtos;
using Tanjameh.Features.Admin.Category.Services;
using Tanjameh.Features.Admin.Product.Services;
using ProductMediaDto = Tanjameh.Features.Admin.Media.Model.ProductMediaDto;


namespace Tanjameh.Features.Admin.Media.Pages;

public partial class ProductMediaManage
{
    [Inject] protected IJSRuntime JSRuntime { get; set; }

    [Inject] protected NavigationManager NavigationManager { get; set; }

    [Inject] protected DialogService DialogService { get; set; }

    [Inject] protected TooltipService TooltipService { get; set; }

    [Inject] protected ContextMenuService ContextMenuService { get; set; }

    [Inject] protected NotificationService NotificationService { get; set; }


    [Inject] public MediaService MediaService { get; set; }

    [Inject] public AdminCategoryService CategoryService { get; set; }

    [Inject] public ProductService ProductService { get; set; }

    protected IEnumerable<ProductMediaDto> productMediaFiles;
    protected IEnumerable<Core.Entities.Category> productCategories;

    protected RadzenDataList<ProductMediaDto> list;
    protected bool isEdit = true;

    public int count { get; set; }

    protected bool errorVisible;
    protected Core.Entities.ProductMediaFile productMediaFile;
    private List<SelectedProductMedia>? selectedProductMedias;

    protected async override Task OnInitializedAsync()
    {
        //import todo change product fetch : parent categories should be add in db, not use complex query in get product
        await InitProductCategories();
        GetFilterValues();
    }

    private async Task InitProductCategories()
    {
        var allCategories = (await CategoryService.GetCategories()).Where(x => x.ParentCategoryId == null).ToList();
        var menCategories = allCategories.Where(x => x.GenderType == GenderType.Men).ToList();
        var womenCategories = allCategories.Where(x => x.GenderType == GenderType.Women).ToList();

        productCategories = new List<Core.Entities.Category>()
        {
            new Core.Entities.Category()
            {
                Name = "مردانه",
                GenderType = GenderType.Men,
                SubCategories = menCategories
            },
            new Core.Entities.Category()
            {
                Name = "زنانه",
                GenderType = GenderType.Women,
                SubCategories = womenCategories
            },
        };
    }

    private async Task LoadData(LoadDataArgs args)
    {
        var baseQuery = await MediaService.GetProductMedia(new Query() { Expand = "Product" });

        baseQuery = ApplyCustomFilter(baseQuery);

        var query = (baseQuery).GroupBy(x => x.ProductId)
            .Select(g => new ProductMediaDto
                { ProductId = g.Key, MediaFiles = g.OrderBy(x => x.DisplayOrder).ToList() })
            .AsQueryable();

        if (!string.IsNullOrEmpty(args.Filter))
        {
            query = query.Where(args.Filter);
        }

        if (!string.IsNullOrEmpty(args.OrderBy))
        {
            query = query.OrderBy(args.OrderBy);
        }

        count = query.Count();

        productMediaFiles = query.Skip(args.Skip.Value).Take(args.Top.Value).ToList();

        if (resetSelectedItems)
            InitSelectedProductMedia();
        
        resetSelectedItems = true;
    }

    private async Task Page(PagerEventArgs args)
    {
        productMediaFiles = new List<ProductMediaDto>();
    }

    private async Task Publish()
    {
        if (selectedProductMedias is null)
            return;

        if (await DialogService.Confirm($"آیا میخواهید این محصولات را منتشر کنید ؟") == false)
            return;

        foreach (var selectedMedias in selectedProductMedias)
        {
            if (selectedMedias.HasAnySelected)
            {
                await ProductService.RejectProduct(selectedMedias.ProductId, false);
                await ProductService.HideProduct(selectedMedias.ProductId, false);

                foreach (var item in selectedMedias.SelectedMedias)
                {
                    await MediaService.HideProductMedia(item.MediaId, !item.Selected);
                }
            }
            else
            {
                await ProductService.RejectProduct(selectedMedias.ProductId);
            }
        }

        list.Reload();
    }

    #region ContextMenu

    private void OnCardContextMenu(MouseEventArgs args, ProductMediaFile productMedia)
    {
        ContextMenuService.Open(args,
            new List<ContextMenuItem>
            {
                new ContextMenuItem() { Text = "Show / Hide", Value = MediaAction.ShowHide, Icon = "visibility" },
                new ContextMenuItem() { Text = "Delete", Value = MediaAction.Delete, Icon = "delete" },
                //new ContextMenuItem(){ Text = "Context menu item 3", Value = 3, Icon = "info" },
            },
            (e) =>
            {
                if ((MediaAction)e.Value == MediaAction.ShowHide)
                {
                    ShowHide(productMedia);
                }
                else if ((MediaAction)e.Value == MediaAction.Delete)
                {
                    Delete(productMedia);
                }
            }
        );
    }

    private async void ShowHide(ProductMediaFile? productMedia)
    {
        var text = productMedia.Hidden ? "نمایش دهید" : "مخفی کنید";
        try
        {
            if (productMedia != null)
            {
                var hideResult = await MediaService.HideProductMedia(productMedia.Id, !productMedia.Hidden);

                if (hideResult != null)
                {
                    await list.Reload();
                }
            }
            else
            {
                var hasManyItems = selectedProductMedias?.Any(x => x.HasAnySelected) == true;
                if (hasManyItems && await DialogService.Confirm($"آیا میخواهید این فایل ها را مخفی کنید ؟") == true)
                {
                    var productMediaIds = GetSelectedProductMediaIds();

                    foreach (var item in productMediaIds)
                    {
                        var bulkDeleteResult = await MediaService.HideProductMedia(item, true);
                    }

                    await list.Reload();

                    return;
                }
            }
        }
        catch (Exception ex)
        {
            NotificationService.Notify(new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = $"Error",
                Detail = $"Unable to show/hide Media"
            });
        }
    }

    private async void Delete(ProductMediaFile? productMedia)
    {
        try
        {
            var hasManyItems = selectedProductMedias?.Any(x => x.HasAnySelected) == true;
            if (await DialogService.Confirm($"آیا می خواهید این فایل${(hasManyItems ? " ها" : "")} را حذف کنید ؟") ==
                true)
            {
                if (hasManyItems)
                {
                    var productMediaIds = GetSelectedProductMediaIds();

                    foreach (var item in productMediaIds)
                    {
                        var bulkDeleteResult = await MediaService.DeleteProductMedia(item);
                    }

                    await list.Reload();

                    return;
                }

                if (productMedia != null)
                {
                    var deleteResult = await MediaService.DeleteProductMedia(productMedia.Id);

                    if (deleteResult != null)
                    {
                        await list.Reload();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            NotificationService.Notify(new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = $"Error",
                Detail = $"Unable to delete Media"
            });
        }
    }

    #endregion

    #region DragAndDrop

    ProductMediaFile? draggedItem;
    ProductMediaDto? draggedGroup;

    private void OnDragStart(DragEventArgs dragEventArgs, ProductMediaFile item, ProductMediaDto group)
    {
        draggedItem = item;
        draggedGroup = group;
    }

    private bool resetSelectedItems = true;

    private async void OnDrop(DragEventArgs dragEventArgs, ProductMediaFile item)
    {
        if (draggedItem != null && draggedGroup != null)
        {
            var draggedIndex = draggedGroup.MediaFiles.IndexOf(draggedItem);
            var droppedIndex = draggedGroup.MediaFiles.IndexOf(item);

            if (droppedIndex == -1)
                return;


            draggedGroup.MediaFiles.Remove(draggedItem);
            draggedGroup.MediaFiles.Insert(draggedIndex <= droppedIndex ? droppedIndex++ : droppedIndex, draggedItem);

            for (int i = 0; i < draggedGroup.MediaFiles.Count(); i++)
            {
                var mediaFile = draggedGroup.MediaFiles[i];
                mediaFile.DisplayOrder = i;
            }

            await MediaService.UpdateProductMediaOrder(draggedGroup.MediaFiles);

            await JSRuntime.InvokeVoidAsync("eval", $"document.querySelector('.hover').classList.remove('hover')");

            resetSelectedItems = false;
            await list.Reload();
        }
    }

    #endregion

    #region SelectItem

    private void ColMultiSelect(int colNumber)
    {
        if (selectedProductMedias is null) return;

        if (selectedProductMedias.All(x =>
            {
                var colSelected = x.GetSelectedCol(colNumber);
                return colSelected == true || colSelected == null;
            }))
        {
            foreach (var item in selectedProductMedias)
            {
                item.SelectCol(colNumber, false);
            }
        }
        else
        {
            foreach (var item in selectedProductMedias)
            {
                item.SelectCol(colNumber, true);
            }
        }
    }

    private void SelectAll()
    {
        if (selectedProductMedias?.All(x => x.Selected) == true)
        {
            foreach (var item in selectedProductMedias)
            {
                item.Selected = false;
            }
        }
        else if (selectedProductMedias != null)
        {
            foreach (var item in selectedProductMedias)
            {
                item.Selected = true;
            }
        }
    }

    private void InitSelectedProductMedia()
    {
        selectedProductMedias = new List<SelectedProductMedia>();

        foreach (var item in productMediaFiles)
        {
            selectedProductMedias.Add(new SelectedProductMedia
            {
                ProductId = item.ProductId,
                SelectedMedias = item.MediaFiles.Select(x => new SelectedMedia() { MediaId = x.Id }).ToList(),
            });
        }
    }

    private List<int> GetSelectedProductMediaIds()
    {
        if (selectedProductMedias == null)
            return new List<int>();

        return selectedProductMedias.SelectMany(x => x.SelectedProductMediaIds).ToList();
    }

    private ElementReference? FullImageModalElement { get; set; }
    private string FullImageModalSrc { get; set; } = string.Empty;

    private async Task ShowFullImage(string imageUrl)
    {
        FullImageModalSrc = imageUrl;

        await JSRuntime.InvokeVoidAsync("tanjameh.bootstrap.modals.show", FullImageModalElement);
    }

    #endregion

    #region Filter

    ProductPublishMode productPublishMode = ProductPublishMode.UnPulished;
    ProductWeightMode productWeightMode = ProductWeightMode.All;

    private object? filterCategory = null;

    private string filterProductyName = string.Empty;
    private List<Lookup> catalogBrands = new List<Lookup>();
    private List<Lookup> productTypes = new List<Lookup>();
    private int? brandFilterId = null;
    private int? typeFilterId = null;

    private IQueryable<ProductMediaFile> ApplyCustomFilter(IQueryable<ProductMediaFile> query)
    {
        if (productPublishMode == ProductPublishMode.UnPulished)
        {
            query = query.Where(x => x.Product.Hidden);
        }
        else if (productPublishMode == ProductPublishMode.Published)
        {
            query = query.Where(x => x.Product.Hidden == false);
        }
        else if (productPublishMode == ProductPublishMode.Rejected)
        {
            query = query.Where(x => x.Product.Rejected == true);
        }


        if (productWeightMode == ProductWeightMode.HasWeight)
        {
            query = query.Where(x => x.Product.LastCalculatedWeightId != null);
        }else if (productWeightMode == ProductWeightMode.HasWeight)
        {
            query = query.Where(x => x.Product.LastCalculatedWeightId == null);
        }
        

        if (filterCategory != null && filterCategory
                is Core.Entities.Category category)
        {
            if (category.Id != default)
            {
                var catIds = CategoryService.GetRelativeCategories(category.Id).Select(x => x.Id).ToArray();
                query = query.Where(x => x.Product.ProductCategories.Any(a => catIds.Contains(a.CategoryId)));  
            }
            else
            {
                query = query.Where(x => x.Product.GenderTypeId == category.GenderTypeId);
            }

        }

        if (!string.IsNullOrEmpty(filterProductyName))
        {
            var filter = filterProductyName.ToLower();
            query = query.Where(x => x.Product.Name.ToLower().Contains(filter));
        }

        if (brandFilterId != null)
        {
            query = query.Where(x => x.Product.CatalogBrandId == brandFilterId);
        }

        if (typeFilterId != null)
        {
            query = query.Where(x => x.Product.ProductTypeId == typeFilterId);
        }

        return query;
    }


    private void ReloadFilter()
    {
        list.CurrentPage = 0;
        list.Reload();
    }

    private void GetFilterValues()
    {
         catalogBrands = MediaService.GetCatalogBrands().ToList();
         productTypes = MediaService.GetProductTypes().ToList();
    }

    #endregion
}

public enum MediaAction
{
    ShowHide,
    Delete
}