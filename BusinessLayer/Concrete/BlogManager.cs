using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        //blog ekleme
        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);

        }

        //blog silme
        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }
       
        //ıd'ye gore blog getırme
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        //blogu yazan yazarı getırme
		public List<Blog> GetBlogByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        //ıd'ye gore blog getırme
        public Blog GetById(int id)
        {
           return _blogDal.GetById(id);
        }

        //son 3 blogu getırme
        public List<Blog> Getlast3Blog()
        {
           return _blogDal.GetListAll().Take(3).ToList();
        }

        //blogu kategori ile getırme
        public List<Blog> GetListWithCategory()
        {
           return _blogDal.GetListWithCategory();
        }

        //butun blogları getırme 
        public List<Blog> ListAllBlog()
        {
            return _blogDal.GetListAll();
        }

        // blog update 
        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

    }
}
