using MovieRental.Application.DTO.Rentals;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Application.Services.Rentals
{
    public partial class RentalService : IRentalService
    {

        private readonly IRentalRepository _rentalRepository;

        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
        public IEnumerable<RentalDTO> GetRentalsByCustomerName(string customerName)
        {
            throw new NotImplementedException();
        }

        public RentalDTO Save(RentalDTO rental)
        {
            throw new NotImplementedException();
        }
    }
}
