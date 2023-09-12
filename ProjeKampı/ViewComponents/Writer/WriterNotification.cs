using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
