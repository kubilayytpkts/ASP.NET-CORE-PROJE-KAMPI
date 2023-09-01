﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProjeKampı.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialdAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialdAddComment(Comment comment)
        {
            comment.CommentStatus = true;
            comment.CommentDate = System.DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.BlogID = 1;
            commentManager.AddComment(comment);
            return NoContent();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var value=commentManager.ListAllComment(id);
            return PartialView(value);
        }
    }
}
