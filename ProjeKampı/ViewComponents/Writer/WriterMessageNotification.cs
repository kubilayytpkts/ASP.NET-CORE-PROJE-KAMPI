using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
