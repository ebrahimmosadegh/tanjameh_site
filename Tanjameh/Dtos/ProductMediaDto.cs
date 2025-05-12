namespace Tanjameh.Dtos;

public class ProductMediaDto
{
    public int DisplayOrder { get; set; }

    public int ProductVarientId { get; set; }

    public string? WebUrl { get; set; }

    public string MediaType { get; set; }

    public string Title { get; set; } = "";

    public string Alt { get; set; } = "";

    //todo Width height
}
