using Microsoft.AspNetCore.Mvc;
using TollFeeCalculator.Application.Dtos;

namespace TollFeeCalculator.WebApi.Controllers
{
	public class TollFeeController : Controller
	{
		public TollFeeController()
		{
			
		}
		[HttpGet]
		[Route("api/[controller]")]
		public async Task<IActionResult> GetAllAsync()
		{
			return Ok();
		}

		[HttpGet]
		[Route("api/[controller]/{id}")]
		public async Task<IActionResult> GetAsync()
		{
			return Ok();
		}

		[HttpPost]
		[Route("api/[controller]")]
		public async Task<IActionResult> AddAsync([FromBody] AddTollFeeDto addTollFeeDto)
		{
			return Ok();
		}

		[HttpDelete]
		[Route("api/[controller]/{id}")]
		public async Task<IActionResult> DeleteAsync(Guid id)
		{
			return Ok();
		}

		[HttpPut]
		[Route("api/[controller]")]
		public async Task<IActionResult> UpdateAsync([FromBody] UpdateTollFeeDto updateTollFeeDto)
		{
			return Ok();
		}

	}
}
