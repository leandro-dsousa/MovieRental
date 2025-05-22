using MovieRental.Application.DTO.Rentals;

namespace MovieRental.Application.Interfaces.Services
{
    public interface IRentalService
    {
        Task<RentalDTO> Save(RentalDTO rental);
        Task<IEnumerable<RentalDTO>> GetRentalsByCustomerName(string customerName);
    }
}
