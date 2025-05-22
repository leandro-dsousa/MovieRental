using MovieRental.Domain.Entities.Rentals;
namespace MovieRental.Application.Interfaces.Repositories;

public interface IRentalRepository
{
    Task<Rental> Save(Rental rental);
    IEnumerable<Rental> GetRentalsByCustomerName(string customerName);
}