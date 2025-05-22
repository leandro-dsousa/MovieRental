using MovieRental.Domain.Entities.Common;
using MovieRental.Domain.Entities.Customers;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Domain.Entities.Rentals
{
    public class Rental : AuditableEntity
    {
        public int Id { get; set; }
        public int DaysRented { get; set; }
        public int MovieId { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public Movie Movie { get; set; }

    }
}
