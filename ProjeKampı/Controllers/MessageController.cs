using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessage());
        public IActionResult GetAllMessageByWriter()
        {
            int manuelId = 19;
            var value = messageManager.GetListByMessage(manuelId);

            return View(value);
        }
        public IActionResult GetMessageByWriterID(int id)
        {
            var value = messageManager.GetWriterByID(id);

            return View(value);
        }
    }
}
