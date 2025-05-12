namespace Tanjameh.Dtos;

public record NameUrl(string Name, string Url);


public record QuickSearchResult(string Name, string Url, string Description = "");