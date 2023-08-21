using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
         void AddCategory(Category category);
         void DeleteCategory(Category category);
         List<Category> ListAllCategory();
         Category GetById(int id);
         void UpdateCategory(Category category);
    }
}
