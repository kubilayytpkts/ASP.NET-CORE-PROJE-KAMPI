using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Areas.Admin.ViewComponents.Widgets
{
    public class statisticsRowTwo:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlogTitle = context.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.lastBlogWriterName = context.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.Writer.WriterName).FirstOrDefault();
            ViewBag.lastBlogId = context.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogID).FirstOrDefault();
            ViewBag.lastBlogWriterId = context.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.WriterID).FirstOrDefault();
            return View();
        }
    }
}
