using MovieRental.Application.DTO.Movies;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Mapping
{
    public class MovieMapping : MappingProfile
    {
        public MovieMapping()
        {
            CreateMap<Movie,MovieDTO>().ReverseMap();
        }
    }
}
