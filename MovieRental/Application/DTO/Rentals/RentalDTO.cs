namespace MovieRental.Application.DTO.Rentals
{
    public class RentalDTO
    {
        public int Id { get; set; }
        public int DaysRented { get; set; }
        public int MovieId { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
    }
}
