
namespace Tanjameh.Core.Abstractions;

public abstract class BaseEntity<T>
{
    public T Id { get; init; }

    public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedOnUtc { get; set; }
}
