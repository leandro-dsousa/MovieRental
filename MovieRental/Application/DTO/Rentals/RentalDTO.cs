namespace MovieRental.Application.DTO.Rentals
{
    public class RentalDTO
    {
        public int DaysRented { get; set; }
        public int MovieId { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }
    }
}
