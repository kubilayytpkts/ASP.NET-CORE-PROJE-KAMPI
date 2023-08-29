using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class WriterSignInController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
