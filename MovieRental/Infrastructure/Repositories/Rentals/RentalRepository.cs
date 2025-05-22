using Microsoft.EntityFrameworkCore;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Domain.Entities.Rentals;
using System.Linq;

namespace MovieRental.Infrastructure.Repositories.Rentals
{
    public class RentalRepository : IRentalRepository
    {
        private readonly MovieRentalDbContext _movieRentalDb;
        public RentalRepository(MovieRentalDbContext movieRentalDb)
        {
            _movieRentalDb = movieRentalDb;
        }

        //TODO: make me async :(
        public async Task<Rental> Save(Rental rental)
        {
            await _movieRentalDb.Rentals.AddAsync(rental);
            _movieRentalDb.SaveChanges();
            return rental;
        }

        //TODO: finish this method and create an endpoint for it
        public async Task<IEnumerable<Rental>> GetRentalsByCustomerName(string customerName, bool tracking)
        {
            return tracking ?
                await _movieRentalDb.Rentals
                    .Include(e => e.Customer)
                    .Where(e => e.Customer.CustomerName == customerName)
                    .ToListAsync() :
                await _movieRentalDb.Rentals
                    .Include(e => e.Customer)
                    .Where(e => e.Customer.CustomerName == customerName)
                    .ToListAsync();
        }

    }
}
