using Microsoft.AspNetCore.Mvc;

namespace TollFeeCalculator.WebApi.Controllers
{
	public class TollPassageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
