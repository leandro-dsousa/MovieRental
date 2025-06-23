using AutoMapper;
using MovieRental.Application.DTO.Rentals;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Application.Services.PaymentProviders;
using MovieRental.Domain.Entities.Rentals;

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

                await _rentalRepository.BeginTransaction();
                
                var rental = _mapper.Map<Rental>(rentalDTO);
                await _rentalRepository.Save(rental);

                IPaymentProvider paymentProvider = PaymentProviderFactory.GetPaymentProvider(rentalDTO.PaymentMethod);

                bool paymentSuccess = await paymentProvider.Pay(rentalDTO.Price);

                if (!paymentSuccess)
                {
                    Console.WriteLine("Payment failed. Rental cannot be saved.");
                    await _rentalRepository.RollbackTransaction();
                    return result; 
                }

                await _rentalRepository.CommitTransaction();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                await _rentalRepository.RollbackTransaction();
            }

            return result;
        }
    }
}
