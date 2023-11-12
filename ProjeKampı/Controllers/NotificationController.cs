using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
