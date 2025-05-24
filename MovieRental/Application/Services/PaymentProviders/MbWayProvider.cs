using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Application.Services.PaymentProviders
{
    public class MbWayProvider : IPaymentProvider
    {
        public Task<bool> Pay(double price)
        {
            //ignore this implementation
            return Task.FromResult(true);
        }
    }
}
