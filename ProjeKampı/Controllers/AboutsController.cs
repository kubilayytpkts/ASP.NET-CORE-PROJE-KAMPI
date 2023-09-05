using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class AboutsController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Media()
        {
           var value = aboutManager.ListAboutAll();
            return View(value);
        }
        public PartialViewResult SocialMedia()
        {
            return PartialView();
        }
    }
}
