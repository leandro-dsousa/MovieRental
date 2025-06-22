using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTO.Rentals;
using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalController : ControllerBase
    {

        private readonly IRentalService _service;

        public RentalController(IRentalService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RentalDTO rental)
        {
	        return Ok(await _service.Save(rental));
        }
        
        [HttpGet("{customerName}")]
        public async Task<IActionResult> GetRentalByCustomerName(string customerName)
        {
            var result = await _service.GetRentalsByCustomerName(customerName);

	        return Ok(result);
        }

	}
}
