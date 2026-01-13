using Microsoft.AspNetCore.Mvc;
using SampleApi.Application.Interfaces;

namespace SampleApi.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerService _service;

		public CustomersController(ICustomerService service)
		{
			_service = service;
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var result = _service.GetById(id);
			return Ok(result);
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_service.GetAll());
		}
	}
}
