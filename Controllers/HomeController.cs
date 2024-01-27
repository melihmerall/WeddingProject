using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeddingProject.Database.Context;
using WeddingProject.Models;

namespace WeddingProject.Controllers
{
    public class HomeController : Controller
    {
		private readonly SqlServerDbContext _context;
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SqlServerDbContext context, IWebHostEnvironment webHostEnvironment)
        {
			_context = context;
			_webHostEnvironment = webHostEnvironment;
			_logger = logger;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var entity = _context.HomePages.FirstOrDefault();
            return View(entity);
        }

    }
}
