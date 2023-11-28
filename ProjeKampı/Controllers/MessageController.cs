using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessage());
        public IActionResult GetAllMessageByWriter()
        {
            var context = new Context();
            var userMail = User.Identity.Name;
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();

            var value = messageManager.GetListByMessage(writerId);

            return View(value);
        }
        public IActionResult GetMessageByWriterID(int id)
        {
            var value = messageManager.GetWriterByID(id);

            return View(value);
        }
    }
}
