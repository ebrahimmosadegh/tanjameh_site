using MediatR;
using Microsoft.AspNetCore.Components;
using Tanjameh.Dtos;
using Tanjameh.Features.BrandAndType.Models;
using Tanjameh.Features.BrandAndType.Queries;

namespace Tanjameh.Features.BrandAndType.Components;

public partial class BrandSectionType
{
    [Inject]
    public IMediator Mediator { get; set; }

    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter(CaptureUnmatchedValues = false), EditorRequired]
    public BrandRequestType BrandRequestType { get; set; }

    [Parameter]
    public string AdditionalUrl { get; set; } = string.Empty;


    private List<NameUrl> NameUrls { get; set; } = new List<NameUrl>();

    protected override async Task OnInitializedAsync()
    {
        if (BrandRequestType == BrandRequestType.ProductType)
        {
            var prodcutTypes = await Mediator.Send(new GetProductTypesQuery());
            NameUrls = prodcutTypes.Select(x => new NameUrl(x.Name, x.ToUrl() + AdditionalUrl)).ToList();
        }
        else
        {
            var brands = await Mediator.Send(new GetBrandsQuery());
            NameUrls = brands.Select(x => new NameUrl(x.Name, x.ToUrl() + AdditionalUrl)).ToList();
        }
    }
}
