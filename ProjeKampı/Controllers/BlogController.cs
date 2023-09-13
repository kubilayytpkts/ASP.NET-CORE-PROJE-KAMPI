using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProjeKampı.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        //Bloglar
        public IActionResult Index()
        {
           var value=blogManager.GetListWithCategory();
            return View(value);
        }
        //seçilen blog id'sini alır ve iletir 
        public IActionResult BlogDetails(int id,int? writerId)
        {
            ViewBag.i = id;
            ViewBag.writerID = writerId;
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }

        //Blogu yazan yazarın yazılarını getırır
        [AllowAnonymous]
        public IActionResult GetBlogWriter()
        {
           var value=blogManager.GetBlogByWriter(18);
           return View(value);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidation Blogvalidation = new BlogValidation();
            ValidationResult result = Blogvalidation.Validate(blog);
            if(result.IsValid)
            {
                blog.WriterID = 14;
                blog.BlogStatus = true;
                blog.BlogCreateDate = System.DateTime.Parse(DateTime.Now.ToShortDateString());
                blogManager.Add(blog);
                return RedirectToAction("GetBlogWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
