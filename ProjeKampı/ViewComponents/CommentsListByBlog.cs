using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents
{
    public class CommentsListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values=commentManager.ListAllComment(5);
            return View(values);
        }
    }
}
