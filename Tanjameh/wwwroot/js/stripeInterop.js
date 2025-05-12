// wwwroot/js/stripeInterop.js

var stripe = null;
var cardElement = null;

window.stripeInterop = {
    initialize: function (publishableKey, cardElementId, cardErrorsId) {
        stripe = Stripe(publishableKey);
        var elements = stripe.elements();

        // Custom styling can be passed to options
        var style = {
            base: {
                fontSize: '16px',
                color: '#32325d',
                fontFamily: '"Helvetica Neue", Helvetica, sans-serif',
                fontSmoothing: 'antialiased',
                '::placeholder': {
                    color: '#aab7c4'
                }
            },
            invalid: {
                color: '#fa755a',
                iconColor: '#fa755a'
            }
        };

        cardElement = elements.create('card', { style: style });
        cardElement.mount('#' + cardElementId);

        // Handle real-time validation errors from the card Element
        cardElement.on('change', function (event) {
            var displayError = document.getElementById(cardErrorsId);
            if (event.error) {
                displayError.textContent = event.error.message;
            } else {
                displayError.textContent = '';
            }
        });
    },
    confirmPayment: async function (clientSecret, cardElementId) {
        if (!stripe || !cardElement) {
            return { success: false, error: 'Stripe has not been initialized.' };
        }

        const result = await stripe.confirmCardPayment(clientSecret, {
            payment_method: {
                card: cardElement,
                // billing_details: { name: 'Jenny Rosen' } // Optional: Add billing details if needed
            }
        });

        if (result.error) {
            // Show error to your customer (e.g., insufficient funds)
            console.error(result.error.message);
            return { success: false, error: result.error.message };
        } else {
            // The payment has been processed!
            if (result.paymentIntent.status === 'succeeded') {
                // Show a success message to your customer
                return { success: true, error: null };
            } else {
                // Handle other statuses like 'requires_action' if necessary
                console.warn('Payment status: ' + result.paymentIntent.status);
                return { success: false, error: 'Payment requires further action or failed. Status: ' + result.paymentIntent.status };
            }
        }
    }
};
