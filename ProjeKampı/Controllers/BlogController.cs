using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        //Bloglar
        [AllowAnonymous]
        public IActionResult Index()
        {
           var value=blogManager.GetListWithCategory();
            return View(value);
        }
        //seçilen blog id'sini alır ve iletir 
        public IActionResult BlogDetails(int id,int writerId)
        {
            ViewBag.i = id;
            ViewBag.writerID = writerId;
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }
    }

}
