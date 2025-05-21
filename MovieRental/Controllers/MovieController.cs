using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTO.Movies;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Movies;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieFeatures _features;

        public MovieController(IMovieFeatures features)
        {
            _features = features;
        }

        [HttpGet]
        public IActionResult Get()
        {
	        return Ok(_features.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] MovieDTO movie)
        {
	        return Ok(/*_features.Save(movie)*/);
        }
    }
}
