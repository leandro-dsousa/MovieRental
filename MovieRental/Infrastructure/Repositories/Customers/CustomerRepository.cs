using Microsoft.EntityFrameworkCore;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Domain.Entities.Customers;

namespace MovieRental.Infrastructure.Repositories.Movies
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MovieRentalDbContext _movieRentalDb;
        public CustomerRepository(MovieRentalDbContext movieRentalDb)
        {
            _movieRentalDb = movieRentalDb;
        }

        public async Task<Customer> Save(Customer customer)
        {
            await _movieRentalDb.Customer.AddAsync(customer);
            _movieRentalDb.SaveChanges();
            return customer;
        }

        // TODO: tell us what is wrong in this method? Forget about the async, what other concerns do you have?
        // As No Trackings
        public Task<List<Customer>> GetAll(bool tracking)
        {
            return tracking ? 
                _movieRentalDb.Customer.ToListAsync() :
                _movieRentalDb.Customer
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
