using MovieRental.Domain.Entities.Customers;
using MovieRental.Domain.Entities.Movies;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRental.Domain.Entities.Rentals
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        public int DaysRented { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }
        public Movie? Movie { get; set; }

    }
}
