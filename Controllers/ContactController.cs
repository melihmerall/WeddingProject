using Microsoft.AspNetCore.Mvc;

namespace WeddingProject.Controllers
{
	public class ContactController : Controller
	{
		[Route("/iletisim")]

		public IActionResult Index()
		{
			return View();
		}
	}
}
