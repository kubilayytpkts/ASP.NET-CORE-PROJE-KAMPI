using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessage());
        public IViewComponentResult Invoke()
        {
            string writerMail = "kubi@hotmail.com";
            var value = writerMessageManager.WriterMessageByWriter(writerMail);

            return View(value);
        }
    }
}
