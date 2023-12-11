using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Areas.Admin.ViewComponents.Widgets
{
    public class statisticsRowFour:ViewComponent
    {
        Context context=new Context();
        public IViewComponentResult Invoke()
        {
           ViewBag.name= context.Admins.Where(x=> x.AdminID == 1).Select(y => y.Name).FirstOrDefault();
           ViewBag.description= context.Admins.Where(x=>x.AdminID == 1).Select(y=>y.ShortDescription).FirstOrDefault();
           ViewBag.image = context.Admins.Where(x => x.AdminID == 1).Select(y => y.ImageUrl).FirstOrDefault();
            return View();
        }
    }
}
