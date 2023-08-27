using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.ViewComponents
{
    public class CommentsListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        //Blog Yorumlarını getir
        public IViewComponentResult Invoke(int id)
        {
            var values=commentManager.ListAllComment(id);
            return View(values);
        }
    }
}
