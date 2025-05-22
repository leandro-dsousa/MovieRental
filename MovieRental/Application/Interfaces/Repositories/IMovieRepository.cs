using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Interfaces.Repositories;

public interface IMovieRepository
{
    Task<Movie> Save(Movie movie);
    Task<List<Movie>> GetAll(bool tracking = false);
}