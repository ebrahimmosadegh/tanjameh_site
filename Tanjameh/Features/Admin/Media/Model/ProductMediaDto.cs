using Tanjameh.Core.Entities;

namespace Tanjameh.Features.Admin.Media.Model;

public class ProductMediaDto
{
    public int ProductId { get; set; }
    public List<ProductMediaFile> MediaFiles { get; set; }
}
