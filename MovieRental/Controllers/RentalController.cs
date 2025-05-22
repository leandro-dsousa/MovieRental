using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.Interfaces.Repositories;
using MovieRental.Domain.Entities.Rentals;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalController : ControllerBase
    {

        private readonly IRentalRepository _features;

        public RentalController(IRentalRepository features)
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
