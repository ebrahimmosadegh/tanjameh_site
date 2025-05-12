using Tanjameh.Core.Helper;

namespace Tanjameh.Dtos;

public record ProductsDto(PagingResponse<ProductPreviewDto> Items, string Titles, AllFilterView FilterView) : PagingResponse<ProductPreviewDto>(Items);

