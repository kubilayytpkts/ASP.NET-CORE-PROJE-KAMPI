using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialdAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog()
        {
            return PartialView();
        }
    }
}
