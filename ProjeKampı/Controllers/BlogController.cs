using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjeKampı.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        //Bloglar
        public IActionResult Index()
        {
            var value = blogManager.GetListWithCategory();
            return View(value);
        }
        //seçilen blog id'sini alır ve iletir 
        public IActionResult BlogDetails(int id, int? writerId)
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
            var value = blogManager.GetCategoryByWriter(18);
            return View(value);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

            
            List<SelectListItem> categoryValues = (from x in categoryManager.ListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();


            ViewBag.Categorys = categoryValues;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidation Blogvalidation = new BlogValidation();
            ValidationResult result = Blogvalidation.Validate(blog);
            if (result.IsValid)
            {
                blog.WriterID = 18;
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
