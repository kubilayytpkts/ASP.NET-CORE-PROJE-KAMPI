using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }
        public void AddCategory(Category category)
        {
            categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> ListAllCategory()
        {
            return categoryDal.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
