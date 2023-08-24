using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
           var value=blogManager.GetListWithCategory();
            return View(value);
        }
        public IActionResult BlogDetails(int id)
        {
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }
    }

}
