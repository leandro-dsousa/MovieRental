using Microsoft.AspNetCore.Mvc;
using MovieRental.Application.DTO.Customers;
using MovieRental.Application.Interfaces.Services;

namespace MovieRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
	        return Ok(_customerService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerDTO customer)
        {
	        return Ok(_customerService.Save(customer));
        }
    }
}
