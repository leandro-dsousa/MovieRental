using MovieRental.Domain.Entities.Common;
using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Domain.Entities.Customers
{
    public class Customer : AuditableEntity
	{
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }

		public ICollection<Rental> Rentals { get; set; }
	}
}
