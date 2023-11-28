using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.ViewComponents.Writer
{
    public class MessageNotification:ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessage());
        public IViewComponentResult Invoke()
        {
            var context = new Context();
            var userMail = User.Identity.Name;
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();

            var value = MessageManager.GetListByMessage(writerId);
            return View(value);
        }
    }
}
