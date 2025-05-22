using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Entities.Customers;
using MovieRental.Domain.Entities.Movies;
using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Infrastructure
{
    public class MovieRentalDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        private string DbPath { get; }

        public MovieRentalDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "movierental.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
