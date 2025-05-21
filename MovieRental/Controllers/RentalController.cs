using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.Interfaces.Services;
using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalController : ControllerBase
    {

        private readonly IRentalFeatures _features;

        public RentalController(IRentalFeatures features)
        {
            _features = features;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Rental rental)
        {
	        return Ok(_features.Save(rental));
        }

	}
}
