using MovieRental.Application.DTO.Movies;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Interfaces.Services
{
    public interface IMovieService
    {
        Movie Save(MovieDTO movie);
        List<MovieDTO> GetAll();
    }
}
