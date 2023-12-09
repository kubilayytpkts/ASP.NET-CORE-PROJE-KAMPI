using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
