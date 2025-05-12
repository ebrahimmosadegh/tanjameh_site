using MediatR;
using Microsoft.AspNetCore.Components;
using Tanjameh.Features.Advers.Queries;

namespace Tanjameh.Features.Shared.Pages;

public partial class Men
{
    [Inject]
    protected IMediator Mediator { get; set; }


    private IReadOnlyCollection<Core.Entities.Banner> Banners { get; set; } = new List<Core.Entities.Banner>();

    protected override async Task OnInitializedAsync()
    {
        Banners = (await Mediator.Send(new GetBannersQuery("./men")))
            .OrderBy(x => x.DisplayOrder).ThenByDescending(x => x.Id).ToList();
    }

}
