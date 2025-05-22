using MovieRental.Application.DTO.Customers;
using MovieRental.Domain.Entities.Customers;

namespace MovieRental.Application.Mapping
{
    public class CustomerMapping : MappingProfile
    {
        public CustomerMapping()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
        }
    }
}
