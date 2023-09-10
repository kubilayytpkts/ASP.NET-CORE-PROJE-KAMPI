using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Blog
{
    public class GetLast3Blog:ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var value=manager.Getlast3Blog();
            return View(value); 
        }
        
    }
}
