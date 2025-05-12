namespace Tanjameh.Core.Enums;

/// <summary>
/// Specifies the source of the product's weight information.
/// </summary>
public enum WeightSource
{
    /// <summary>
    /// The weight source is unknown or not yet determined.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// The weight was obtained from an external API (e.g., Amazon).
    /// </summary>
    ExternalApi = 1,

    /// <summary>
    /// The weight was estimated based on internal rules (category, material, etc.).
    /// </summary>
    Estimated = 2,

    /// <summary>
    /// The weight was manually entered, likely after actual measurement.
    /// </summary>
    ManualEntry = 3
}

