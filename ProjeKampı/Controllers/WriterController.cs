using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
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
    }
}
