using Microsoft.EntityFrameworkCore;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Domain.Entities.Rentals;

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
        public IEnumerable<Rental> GetRentalsByCustomerName(string customerName)
        {
            return [];
        }

    }
}
