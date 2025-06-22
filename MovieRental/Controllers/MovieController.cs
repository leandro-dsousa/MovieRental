using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTO.Movies;
using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get()
        {
	        return Ok(_movieService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] MovieDTO movie)
        {
	        return Ok(_movieService.Save(movie));
        }
    }
}
