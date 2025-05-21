using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Infrastructure.Repositories.Movies
{
    public class MovieFeatures : IMovieFeatures
    {
        private readonly MovieRentalDbContext _movieRentalDb;
        public MovieFeatures(MovieRentalDbContext movieRentalDb)
        {
            _movieRentalDb = movieRentalDb;
        }

        public Movie Save(Movie movie)
        {
            _movieRentalDb.Movies.Add(movie);
            _movieRentalDb.SaveChanges();
            return movie;
        }

        // TODO: tell us what is wrong in this method? Forget about the async, what other concerns do you have?
        // As No Trackings
        public List<Movie> GetAll()
        {
            return _movieRentalDb.Movies.ToList();
        }


    }
}
