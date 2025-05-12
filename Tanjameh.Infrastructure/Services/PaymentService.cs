using Microsoft.Extensions.Configuration;
using Stripe;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data; // Assuming OrderService might be needed later

namespace Tanjameh.Infrastructure.Services;

public class PaymentService : IPaymentService
{
    private readonly IConfiguration _config;
    private readonly ApplicationDbContext _context; // Might be needed for updating order status

    public PaymentService(IConfiguration config, ApplicationDbContext context)
    {
        _config = config;
        _context = context;
        // Initialize Stripe API key
        StripeConfiguration.ApiKey = _config["Stripe:SecretKey"];
    }

    public async Task<PaymentIntent?> CreateOrUpdatePaymentIntent(Order order)
    {
        var service = new PaymentIntentService();
        PaymentIntent intent;

        // Stripe requires amount in the smallest currency unit (e.g., cents for USD, fils for AED)
        // Assuming the currency is USD for now. Adjust if needed.
        var amountInCents = (long)(order.TotalAmount * 100);

        if (string.IsNullOrEmpty(order.PaymentIntentId))
        {
            // Create a new Payment Intent
            var options = new PaymentIntentCreateOptions
            {
                Amount = amountInCents,
                Currency = "usd", // TODO: Make currency configurable or derive from order
                PaymentMethodTypes = new List<string> { "card" },
                Metadata = new Dictionary<string, string> { { "OrderId", order.Id.ToString() } }
            };
            intent = await service.CreateAsync(options);
            // Update the order with the new PaymentIntentId (important!)
            order.PaymentIntentId = intent.Id;
            // Note: Need to save this change to the database, ideally within the same transaction or shortly after.
            // This might require injecting IOrderService or modifying OrderService to handle this update.
            // For now, we assume the caller handles saving the updated order.PaymentIntentId.
        }
        else
        {
            // Update existing Payment Intent (e.g., if cart/order amount changed)
            var options = new PaymentIntentUpdateOptions
            {
                Amount = amountInCents
                // Currency cannot be updated
            };
            intent = await service.UpdateAsync(order.PaymentIntentId, options);
        }

        return intent;
    }

    // TODO: Implement webhook handling method
    // public async Task HandleStripeWebhook(string json, string stripeSignature)
    // {
    //     var webhookSecret = _config["Stripe:WebhookSecret"]; // Need to add this to config
    //     var stripeEvent = EventUtility.ConstructEvent(json, stripeSignature, webhookSecret);
    //
    //     // Handle the event (e.g., payment_intent.succeeded, payment_intent.payment_failed)
    //     if (stripeEvent.Type == Events.PaymentIntentSucceeded)
    //     {
    //         var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
    //         // Find the order associated with the PaymentIntent
    //         // Update order status to Paid/Processing
    //         // Fulfill the order (e.g., send confirmation email)
    //     }
    //     else if (stripeEvent.Type == Events.PaymentIntentPaymentFailed)
    //     {
    //         var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
    //         // Find the order associated with the PaymentIntent
    //         // Update order status to Failed
    //         // Notify user
    //     }
    //     // ... handle other event types
    // }
}
