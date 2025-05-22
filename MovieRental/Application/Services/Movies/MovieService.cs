using AutoMapper;
using MovieRental.Application.DTO.Movies;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Application.Services.Movies
{
    public partial class MovieService : IMovieService
    {

        private readonly IMovieRepository _movieRepository;
        private readonly ILogger<MovieService> _logger;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, ILogger<MovieService> logger, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<MovieDTO>> GetAll()
        {
            var result = new List<MovieDTO>();

            try
            {
                var movies = await _movieRepository.GetAll();
                result = _mapper.Map<List<MovieDTO>>(movies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }

        public async Task<MovieDTO> Save(MovieDTO movieDTO)
        {
            var result = new MovieDTO();

            try
            {
                var movie = _mapper.Map<Movie>(movieDTO);

                await _movieRepository.Save(movie);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return movieDTO;
        }
    }
}
