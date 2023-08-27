using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    public class WriterRegisterController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterImage = "Deneme";
            writer.WriterImage = "Deneme";
            writer.WriterAbout = "Deneme";
            manager.AddWriter(writer);
            return RedirectToAction("Index","Blog");
        }

    }
}
