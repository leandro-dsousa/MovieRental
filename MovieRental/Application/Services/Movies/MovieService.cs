using MovieRental.Application.DTO.Movies;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Services.Movies
{
    public partial class MovieService : IMovieService
    {

        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<MovieDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie Save(MovieDTO movie)
        {
            throw new NotImplementedException();
        }
    }
}
