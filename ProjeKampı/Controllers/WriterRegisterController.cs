using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class WriterRegisterController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidation validations = new WriterValidation();
            ValidationResult Result = validations.Validate(writer);
            if(Result.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterImage = null;
                writer.WriterAbout = "Deneme";
                manager.Add(writer);
               // return RedirectToAction("Index","WriterRegister");
            }

            else
            {
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }  
            }
            return View();
        }

    }
}
