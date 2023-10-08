using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
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

        public IActionResult BlogDelete(int id)
        {
            var value = blogManager.GetById(id);
            blogManager.Delete(value);
            return RedirectToAction("GetBlogWriter");
        }

        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            List<SelectListItem> categoryValues = (from x in categoryManager.ListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            var returnvalue = blogManager.GetById(id);
            ViewBag.Categorys = categoryValues;

            return View(returnvalue);
        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog blog)
        {
            var createTimeValue = blogManager.GetById(blog.BlogID);
            blog.WriterID = createTimeValue.WriterID;
            blog.BlogCreateDate = createTimeValue.BlogCreateDate;
            blog.BlogStatus = true;
            blogManager.Update(blog);
            return RedirectToAction("GetBlogWriter");
        }

    }
}
