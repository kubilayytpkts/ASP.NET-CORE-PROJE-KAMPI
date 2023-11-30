using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
