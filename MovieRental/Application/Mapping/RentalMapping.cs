using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Application.Mapping
{
    public class RentalMapping : MappingProfile
    {
        public RentalMapping()
        {
            CreateMap<Rental,RentalMapping>().ReverseMap();
        }
    }
}
