using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using ProjeKampı.Controllers;
using System.Linq;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager WriterManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {

            var context = new Context();
            var userMail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == userMail).
                                       Select(y => y.WriterID).FirstOrDefault();
            var values = WriterManager.GetWriterById(writerID);
            return View(values);
        }

    }
}
