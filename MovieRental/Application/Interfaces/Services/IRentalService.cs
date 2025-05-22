using MovieRental.Application.DTO.Rentals;

namespace MovieRental.Application.Interfaces.Services
{
    public interface IRentalService
    {
        RentalDTO Save(RentalDTO rental);
        IEnumerable<RentalDTO> GetRentalsByCustomerName(string customerName);
    }
}
