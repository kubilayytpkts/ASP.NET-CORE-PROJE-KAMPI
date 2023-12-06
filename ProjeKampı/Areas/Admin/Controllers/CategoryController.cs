using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.EntityFramework;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        
        {
            var value = categoryManager.ListAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidation validation = new CategoryValidation();
            ValidationResult validationResult = validation.Validate(category);
            if(validationResult.IsValid)
            {
                category.CategoryStatus = true;
                categoryManager.Add(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult ActivatedCategory(int id)
        {
            var selectedCategory = categoryManager.GetById(id);
            selectedCategory.CategoryStatus = true;
            categoryManager.Update(selectedCategory);
            return RedirectToAction("Index");
        }

        public IActionResult PassivatingCategory(int id)
        {
            var selectedCategory = categoryManager.GetById(id);
            selectedCategory.CategoryStatus = false;
            categoryManager.Update(selectedCategory);

            return RedirectToAction("Index");
        }
    }
}
