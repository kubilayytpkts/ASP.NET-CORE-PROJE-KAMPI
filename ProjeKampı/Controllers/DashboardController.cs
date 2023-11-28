using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Controllers
{
    public class DashboardController : Controller
    {       
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
