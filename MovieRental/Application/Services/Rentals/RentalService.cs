using AutoMapper;
using MovieRental.Application.DTO.Movies;
using MovieRental.Application.DTO.Rentals;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Application.Services.Movies;
using MovieRental.Domain.Entities.Rentals;
using MovieRental.Infrastructure.Repositories.Movies;

namespace MovieRental.Application.Services.Rentals
{
    public partial class RentalService : IRentalService
    {

        private readonly IRentalRepository _rentalRepository;
        private readonly ILogger<RentalService> _logger;
        private readonly IMapper _mapper;

        public RentalService(IRentalRepository rentalRepository, ILogger<RentalService> logger, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RentalDTO>> GetRentalsByCustomerName(string customerName)
        {
            
            var result = new List<RentalDTO>();

            try
            {
                var rentals = await _rentalRepository.GetRentalsByCustomerName(customerName);
                result = _mapper.Map<List<RentalDTO>>(rentals);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }

        public async Task<RentalDTO> Save(RentalDTO rentalDTO)
        {
            var result = new RentalDTO();

            try {

                var rental = _mapper.Map<Rental>(rentalDTO);
                await _rentalRepository.Save(rental);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }
    }
}
