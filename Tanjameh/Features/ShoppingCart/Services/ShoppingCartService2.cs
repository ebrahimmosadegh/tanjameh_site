//using Microsoft.EntityFrameworkCore;
//using Tanjameh.Infrastructure.Data;

//namespace Tanjameh.Features.ShoppingCart.Services;



//public class ShoppingCartService2 { 
//    private readonly IHttpContextAccessor _httpContextAccessor;
//    private readonly ApplicationDbContext _dbContext;
//    private readonly ISession _session;

//    public ShoppingCartService2(IHttpContextAccessor httpContextAccessor, ApplicationDbContext dbContext)
//    { 
//        _httpContextAccessor = httpContextAccessor;
//        _dbContext = dbContext;
//        _session = _httpContextAccessor.HttpContext.Session;
//    }

//    public async Task<Core.Entities.ShoppingCart> GetOrCreateCartAsync(int? customerId = null)
//    {
//        Core.Entities.ShoppingCart? cart;

//        if (customerId.HasValue)
//        {
//            // Get from database for logged in user
//            cart = await _dbContext.ShoppingCarts
//                            .Include(c => c.Items)
//                            .FirstOrDefaultAsync(c => c.CustomerId == customerId);
//        }
//        else
//        {
//            // Get from session for guest user  
//            var cartId = _session.GetString("CartId");
//            if (cartId != null)
//            {
//                cart = await _dbContext.ShoppingCarts
//                                .Include(c => c.Items)  
//                                .FirstOrDefaultAsync(c => c.Id == Guid.Parse(cartId));
//            }
//            else
//            {
//                cart = new Core.Entities.ShoppingCart();
//                _session.SetString("CartId", cart.Id.ToString());
//            }
//        }

//        return cart;
//    }

//    // Implement other methods for add/update/remove here...

//    public async Task MigrateCartAsync(Guid anonymousId, int customerId)
//    {
//        // Retrieve anonymous cart
//        var anonymousCart = await _dbContext.ShoppingCarts
//                                 .Include(c => c.Items)
//                                 .FirstOrDefaultAsync(c => c.Id == anonymousId);
//        if (anonymousCart == null) return;

//        // Retrieve current logged in customer cart
//        var customerCart = await _dbContext.ShoppingCarts  
//                                .Include(c => c.Items)
//                                .FirstOrDefaultAsync(c => c.CustomerId == customerId);

//        if (customerCart == null)
//        {
//            // Assign anonymous cart to logged in customer
//            anonymousCart.CustomerId = customerId;
//        }
//        else
//        {
//            // Merge anonymous cart items into customer cart
//            foreach(var item in anonymousCart.Items) 
//            {
//                var existingItem = customerCart.Items.FirstOrDefault(i => i.ProductId == item.ProductId);
//                if (existingItem != null)
//                {
//                    existingItem.Quantity += item.Quantity; 
//                }
//                else
//                {
//                    customerCart.Items.Add(item);
//                }
//            }

//            // Remove anonymous cart
//            _dbContext.ShoppingCarts.Remove(anonymousCart);  
//        }

//        // Persist changes
//        await _dbContext.SaveChangesAsync();

//        // Remove cart id from session
//        _session.Remove("CartId");
//    }  
//}