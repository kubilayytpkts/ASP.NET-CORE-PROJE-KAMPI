using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListByWriter(int id)
        {
            using (var value = new Context())
            {
                return value.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }

        public List<Blog> GetListWithCategory()
        {
            using(var value=new Context())
            {
               return value.Blogs.Include(x=>x.Category).ToList();
            }
        }

    }
}
