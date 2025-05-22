using MovieRental.Domain.Entities.Customers;

namespace MovieRental.Application.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> Save(Customer movie);
        Task<List<Customer>> GetAll(bool tracking = false);
    }
}
