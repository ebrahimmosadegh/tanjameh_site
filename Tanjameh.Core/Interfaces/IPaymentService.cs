using Tanjameh.Core.Entities;
using Stripe;

namespace Tanjameh.Core.Interfaces;

public interface IPaymentService
{
    Task<PaymentIntent?> CreateOrUpdatePaymentIntent(Order order);
    // Add other methods as needed, e.g., handling webhooks
}
