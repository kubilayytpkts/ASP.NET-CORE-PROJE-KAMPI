using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        //ekleme
        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }
        //silme
        public void Delete(Blog blog)
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

        public List<Blog> GetCategoryByWriter(int id)
        {
           return _blogDal.GetListByWriter(id);
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

        //bütün blogları getırme 
        public List<Blog> ListAll()
        {
            return _blogDal.GetListAll();
        }

        //blog güncelleme
        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }

    }
}
