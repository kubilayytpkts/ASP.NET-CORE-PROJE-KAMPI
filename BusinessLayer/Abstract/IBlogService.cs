using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogByWriter(int id);
        List<Blog> Getlast3Blog();
        List<Blog> GetCategoryByWriter(int id);
    }
}
