using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjeKampı.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager Manager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var value = Manager.GetListWithCategory();
            return View(value);
        }
    }
}
