using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
