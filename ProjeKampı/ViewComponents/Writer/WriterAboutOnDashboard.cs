using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterAboutOnDashboard: ViewComponent
    {
        WriterManager WriterManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        
        {
            var values = WriterManager.GetWriterById(1);
            return View(values);
        }

    }
}
