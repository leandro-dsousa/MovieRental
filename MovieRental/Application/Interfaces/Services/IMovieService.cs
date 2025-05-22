using MovieRental.Application.DTO.Movies;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Interfaces.Services
{
    public interface IMovieService
    {
        Task<MovieDTO> Save(MovieDTO movie);
        Task<List<MovieDTO>> GetAll();
    }
}
