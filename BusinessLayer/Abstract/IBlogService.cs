using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> ListAllBlog();
        Blog GetById(int id);
        void UpdateBlog(Blog blog);
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogByWriter(int id);
    }
}
