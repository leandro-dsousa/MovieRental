using MovieRental.Domain.Entities.Rentals;
namespace MovieRental.Application.Interfaces.Services;

public interface IRentalFeatures
{
    Rental Save(Rental rental);
    IEnumerable<Rental> GetRentalsByCustomerName(string customerName);
}