using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    [Authorize]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult NavbarPartialView()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }
        public IActionResult EditProfile()
        {
            var value=writerManager.GetById(18);
            return View(value);
        }
    }
}
