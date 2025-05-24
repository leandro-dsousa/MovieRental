using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Application.Services.PaymentProviders
{
    public class PaymentProviderFactory
    {
        public static IPaymentProvider GetPaymentProvider(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "MbWay":
                    return new MbWayProvider();
                case "PayPal":
                    return new PayPalProvider();
                default:
                    throw new ArgumentException("Unsupported payment method", nameof(paymentMethod));
            }
        }
    }
}
