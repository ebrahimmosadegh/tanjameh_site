using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Dtos;

public class JsonImportDto
{
    public Guid Id { get;  set; } = Guid.NewGuid();

    [Required]
    public string Content { get;  set; } = string.Empty;
}