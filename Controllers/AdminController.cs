using Microsoft.AspNetCore.Mvc;
using WeddingProject.Database.Context;
using WeddingProject.Entities;
using WeddingProject.Helpers.AlertControl;
using WeddingProject.Helpers.FileControl;
using WeddingProject.Models;

namespace WeddingProject.Controllers
{
	public class AdminController : Controller
	{
		private readonly SqlServerDbContext _context;
		private readonly IWebHostEnvironment _webHostEnvironment;
		public AdminController(SqlServerDbContext context, IWebHostEnvironment webHostEnvironment)
		{
			_context = context;
			_webHostEnvironment = webHostEnvironment;
		}
		[Route("/admin/anasayfa")]
		public IActionResult Index()
		{
			return View();
		}
		[Route("/admin/anasayfaDüzenle")]
		[HttpGet]
		public IActionResult MainPageEdit()
		{
			var entity = _context.HomePages?.FirstOrDefault();
			return View(entity);
		}
		[Route("/admin/anasayfaDüzenle")]
		[HttpPost]
		public IActionResult MainPageEdit(HomePage model, IFormFile hp1i, IFormFile hp2i, IFormFile hp3i, IFormFile hp4i, IFormFile slideri1, IFormFile slideri2, IFormFile slideri3)
		{
			var entity = _context.HomePages?.FirstOrDefault(x => x.Id == model.Id);

			if (entity == null)
			{
				var newEntity = new HomePage()
				{
					HomePageDesc1 = model.HomePageDesc1,
					HomePageDesc2 = model.HomePageDesc2,
					HomePageDescTitle = model.HomePageDescTitle,
					HomePage1ImgPath = hp1i != null ? FileHelper.UploadedFile(_webHostEnvironment, hp1i, "Anasayfa") : null,
					HomePage2ImgPath = hp2i != null ? FileHelper.UploadedFile(_webHostEnvironment, hp2i, "Anasayfa") : null,
					HomePage3ImgPath = hp3i != null ? FileHelper.UploadedFile(_webHostEnvironment, hp3i, "Anasayfa") : null,
					HomePage4ImgPath = hp4i != null ? FileHelper.UploadedFile(_webHostEnvironment, hp4i, "Anasayfa") : null,
					OurHistoryDesc = model.OurHistoryDesc,
					OurHistoryStick1 = model.OurHistoryStick1,
					OurHistoryStick2 = model.OurHistoryStick2,
					OurHistoryStick3 = model.OurHistoryStick3,
					OurHistoryStick4 = model.OurHistoryStick4,
					OurHistoryStick5 = model.OurHistoryStick5,
					OurHistoryStick6 = model.OurHistoryStick6,
					OurHistoryTitle = model.OurHistoryTitle,
					Service1Desc = model.Service1Desc,
					Service2Desc = model.Service2Desc,
					Service3Desc = model.Service3Desc,
					Service4Desc = model.Service4Desc,
					Service1Name = model.Service1Name,
					Service2Name = model.Service2Name,
					Service3Name = model.Service3Name,
					Service4Name = model.Service4Name,
					Slider1ImgPath = slideri1 != null ? FileHelper.UploadedFile(_webHostEnvironment, slideri1, "Anasayfa") : null,
					Slider2ImgPath = slideri2 != null ? FileHelper.UploadedFile(_webHostEnvironment, slideri2, "Anasayfa") : null,
					Slider3ImgPath = slideri2 != null ? FileHelper.UploadedFile(_webHostEnvironment, slideri3, "Anasayfa") : null,
					Slider1Title = model.Slider1Title,
					Slider2Title = model.Slider2Title,
					Slider3Title = model.Slider3Title,
				};
				TempData.Put("message", new AlertMessage()
				{
					Title = "Bilgi!",
					Message = "Ekleme başarılı.",
					AlertType = "success"
				});
				_context.HomePages.Add(newEntity);
				_context.SaveChanges();
			}
			else
			{
				entity.HomePageDesc1 = model.HomePageDesc1;
				entity.HomePageDesc2 = model.HomePageDesc2;
				entity.HomePageDescTitle = model.HomePageDescTitle;
				if (hp1i != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.HomePage1ImgPath);

					entity.HomePage1ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, hp1i, "Anasayfa");
				}
				if (hp2i != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.HomePage2ImgPath);

					entity.HomePage2ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, hp2i, "Anasayfa");
				}
				if (hp3i != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.HomePage3ImgPath);

					entity.HomePage3ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, hp3i, "Anasayfa");
				}
				if (hp4i != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.HomePage4ImgPath);

					entity.HomePage4ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, hp4i, "Anasayfa");
				}
				entity.OurHistoryDesc = model.OurHistoryDesc;
				entity.OurHistoryStick1 = model.OurHistoryStick1;
				entity.OurHistoryStick2 = model.OurHistoryStick2;
				entity.OurHistoryStick3 = model.OurHistoryStick3;
				entity.OurHistoryStick4 = model.OurHistoryStick4;
				entity.OurHistoryStick5 = model.OurHistoryStick5;
				entity.OurHistoryStick6 = model.OurHistoryStick6;
				entity.OurHistoryTitle = model.OurHistoryTitle;
				entity.Service1Desc = model.Service1Desc;
				entity.Service2Desc = model.Service2Desc;
				entity.Service3Desc = model.Service3Desc;
				entity.Service4Desc = model.Service4Desc;
				entity.Service1Name = model.Service1Name;
				entity.Service2Name = model.Service2Name;
				entity.Service3Name = model.Service3Name;
				entity.Service4Name = model.Service4Name;
				if (slideri1 != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.Slider1ImgPath);

					entity.Slider1ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, slideri1, "Anasayfa");
				}
				if (slideri2 != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.Slider2ImgPath);

					entity.Slider2ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, slideri2, "Anasayfa");
				}
				if (slideri3 != null)
				{
					FileHelper.DeleteImageFromFile(_webHostEnvironment, "Anasayfa", entity.Slider3ImgPath);

					entity.Slider3ImgPath =
						FileHelper.UploadedFile(_webHostEnvironment, slideri3, "Anasayfa");
				}
				entity.Slider1Title = model.Slider1Title;
				entity.Slider2Title = model.Slider2Title;
				entity.Slider3Title = model.Slider3Title;

				_context.HomePages.Update(entity);
				_context.SaveChanges();

				TempData.Put("message", new AlertMessage()
				{
					Title = "Bilgi!",
					Message = "Başarı ile Güncellendi.",
					AlertType = "success"
				});
			}


			return View();
		}
	}

}
