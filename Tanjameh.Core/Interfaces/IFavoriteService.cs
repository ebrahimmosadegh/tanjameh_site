using Tanjameh.Core.Entities;

namespace Tanjameh.Core.Interfaces;

/// <summary>
/// Interface for managing user favorites.
/// </summary>
public interface IFavoriteService
{
    /// <summary>
    /// Gets a list of user IDs who have favorited a specific product variant.
    /// </summary>
    /// <param name="variantId">The ID of the product variant.</param>
    /// <returns>A list of user IDs.</returns>
    Task<List<long>> GetUserIdsWithFavoriteVariantAsync(int variantId);

    // TODO: Add other favorite management methods (Add, Remove, GetByUser, etc.) as needed.
}

