using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Writer
{
    public class MessageNotification:ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessage());
        public IViewComponentResult Invoke()
        {

            var value = MessageManager.GetListByMessage(19);

            return View(value);
        }
    }
}
