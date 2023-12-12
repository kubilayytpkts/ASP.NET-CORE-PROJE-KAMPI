using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace ProjeKampı.Areas.Admin.ViewCompanents.StaticRowOne
{
    public class statisticsRowOne:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            string apiKey = "22bec25ac984b19f72cf1195da069a38";
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q=Turkey&mode=xml&lang=tr&units=metric&appid={apiKey}";
            XDocument weatherDocument = XDocument.Load(apiUrl);
            ViewBag.cityWeatherValue = weatherDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            ViewBag.blogCount = context.Blogs.Count();
            ViewBag.contactCount = context.Contacts.Count();
            ViewBag.categoryCount = context.Categories.Count();
            return View();
        }
    }
}
