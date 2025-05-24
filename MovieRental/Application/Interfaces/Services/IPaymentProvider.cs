namespace MovieRental.Application.Interfaces.Services
{
    public interface IPaymentProvider
    {
        Task<bool> Pay(double price);
    }
}
