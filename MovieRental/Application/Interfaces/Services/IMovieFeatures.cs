using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Interfaces.Services;

public interface IMovieFeatures
{
    Movie Save(Movie movie);
    List<Movie> GetAll();
}