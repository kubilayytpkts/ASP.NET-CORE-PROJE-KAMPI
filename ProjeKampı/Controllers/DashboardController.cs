using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.BlogCount = c.Blogs.Count();
            ViewBag.WriterBlogCount = c.Blogs.Where(x => x.WriterID == 18).Count();
            ViewBag.CategoryCount = c.Categories.Count();
            return View();
        }
    }
}
