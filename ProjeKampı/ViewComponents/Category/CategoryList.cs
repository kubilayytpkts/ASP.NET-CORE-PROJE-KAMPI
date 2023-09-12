using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjeKampı.ViewComponents
{
    public class CategoryList:ViewComponent
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
           var values = manager.ListAll();
            return View(values);
        }
    }
}
