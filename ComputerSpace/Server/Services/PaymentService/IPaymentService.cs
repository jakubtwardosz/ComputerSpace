using Stripe.Checkout;

namespace ComputerSpace.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<Session> CreateCheckoutSession();
    }
}
