using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Interfaces.Repositories;

public interface IMovieRepository
{
    Movie Save(Movie movie);
    List<Movie> GetAll();
}