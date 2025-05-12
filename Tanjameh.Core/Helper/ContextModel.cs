

namespace Tanjameh.Core.Helper;

public class ContextModel<T>
{
    public required T Value { get; set; }

    public required Func<ValueTask> DisposeAsync { get; set; }
}
