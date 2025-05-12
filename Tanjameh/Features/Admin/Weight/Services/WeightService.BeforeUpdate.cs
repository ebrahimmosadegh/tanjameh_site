using DocumentFormat.OpenXml.InkML;
using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Weight.Services;

public partial class WeightService
{
    partial void OnProductWeightPriceCreated(ProductWeightPrice item)
    {
        if(Context.ProductWeightPrice.Any(x=>x.WeightId == item.WeightId))
        {
            throw new Exception("Config with this weight exist!");
        }

        item.UpdatedOnUtc = DateTime.UtcNow;
    }

    partial void OnProductWeightPriceUpdated(ProductWeightPrice item)
    {
        var existItem = Context.ProductWeightPrice.SingleOrDefault(x => x.WeightId == item.WeightId);
        if (existItem is not null && existItem.Id != item.Id)
        {
            throw new Exception("Config with this weight exist!");
        }


        item.UpdatedOnUtc = DateTime.UtcNow;
    }

}
