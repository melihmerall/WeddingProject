using Microsoft.AspNetCore.Mvc;

namespace WeddingProject.Controllers
{
	public class AboutController : Controller
	{
		[Route("/hakkimizda")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
