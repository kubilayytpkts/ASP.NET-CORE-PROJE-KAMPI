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

        public void Add(Category category)
        {
            categoryDal.Insert(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }


        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> ListAll()
        {
            return categoryDal.GetListAll();
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
