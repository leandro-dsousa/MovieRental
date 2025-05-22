using MovieRental.Application.DTO.Customers;

namespace MovieRental.Application.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<CustomerDTO> Save(CustomerDTO customerDTO);
        Task<List<CustomerDTO>> GetAll();
    }
}
