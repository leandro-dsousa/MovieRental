using MovieRental.Domain.Entities.Common;
using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Domain.Entities.Movies
{
    public class Movie : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
