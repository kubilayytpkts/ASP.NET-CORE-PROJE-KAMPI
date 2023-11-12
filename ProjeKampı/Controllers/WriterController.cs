using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System;

namespace ProjeKampı.Controllers
{
    [Authorize]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult NavbarPartialView()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartialView()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            var value = writerManager.GetById(18);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditProfile(Writer writer)
        {
            WriterValidation validations = new WriterValidation();
            ValidationResult validationResult = validations.Validate(writer);
            if (validationResult.IsValid)
            {
                writer.WriterID = 18;
                writerManager.Update(writer);
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                // Genel hata mesajını ekle
                ModelState.AddModelError("", "Güncelleme sırasında bir hata oluştu!");

                // ModelState'i incele ve konsola yazdır
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine($"Property: {modelState.Errors}, Error: {error.ErrorMessage}");
                    }
                }
            }
            return View();
        }

    }
}
