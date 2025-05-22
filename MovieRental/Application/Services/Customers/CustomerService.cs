using AutoMapper;
using MovieRental.Application.DTO.Customers;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Customers;

namespace MovieRental.Application.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerService> _logger;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, ILogger<CustomerService> logger, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<CustomerDTO>> GetAll()
        {
            var result = new List<CustomerDTO>();

            try
            {
                var movies = await _customerRepository.GetAll();
                result = _mapper.Map<List<CustomerDTO>>(movies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }

        public async Task<CustomerDTO> Save(CustomerDTO customerDTO)
        {
            var result = new CustomerDTO();

            try
            {
                var customer = _mapper.Map<Customer>(customerDTO);

                await _customerRepository.Save(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return customerDTO;
        }
    }
}
