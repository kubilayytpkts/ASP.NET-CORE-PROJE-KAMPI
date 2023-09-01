using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class NewsletterController : Controller
    {
        
        NewsletterManager manager = new NewsletterManager(new EfNewsletterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //mail bülteni
        [HttpPost]
        public IActionResult Index(NewsLetter newsletter)
        {
            newsletter.active = true;
            manager.add(newsletter);
            return NoContent();
        }
    }
}
