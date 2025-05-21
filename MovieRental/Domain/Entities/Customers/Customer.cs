using System.ComponentModel.DataAnnotations;

namespace MovieRental.Domain.Entities.Customers
{
    public class Customer
	{
		[Key]
		public int Id { get; set; }
		public string CustomerName { get; set; }

	}
}
