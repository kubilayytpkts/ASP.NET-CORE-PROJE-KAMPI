using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager manager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke(int id)
		{
			var values = manager.GetBlogByWriter(id);
			return View(values);
		}
	}
}
