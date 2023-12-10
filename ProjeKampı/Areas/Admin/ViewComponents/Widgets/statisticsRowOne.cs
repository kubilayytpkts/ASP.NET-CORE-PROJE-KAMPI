using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;

namespace ProjeKampı.Areas.Admin.ViewCompanents.StaticRowOne
{
    public class statisticsRowOne:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.blogCount = context.Blogs.Count();
            ViewBag.contactCount = context.Contacts.Count();
            ViewBag.categoryCount = context.Categories.Count();
            return View();
        }
    }
}
