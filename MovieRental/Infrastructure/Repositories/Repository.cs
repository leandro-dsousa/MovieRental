using MovieRental.Application.Interfaces.Repositories;

namespace MovieRental.Infrastructure.Repositories.Rentals
{
    public class Repository : IRepository
    {
        private readonly MovieRentalDbContext _movieRentalDb;
        private readonly ILogger _logger;

        public Repository(MovieRentalDbContext movieRentalDb, ILogger logger)
        {
            _movieRentalDb = movieRentalDb;
            _logger = logger;
        }

        public async Task<string> SaveInTransaction(string genericError)
        {
            try
            {
                if (await _movieRentalDb.SaveChangesAsync() == 0)
                {
                    _logger.LogInformation("Api_No_Changes");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.GetBaseException().Message);
            }

            return null;
        }

        public async Task BeginTransaction()
        {
            await _movieRentalDb.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction()
        {
            await _movieRentalDb.Database.CommitTransactionAsync();
        }

        public async Task RollbackTransaction()
        {
            await _movieRentalDb.Database.RollbackTransactionAsync();
        }
    }
}
        