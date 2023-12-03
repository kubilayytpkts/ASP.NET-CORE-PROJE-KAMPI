using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation() 
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori adı boş olamaz !");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 karakterden küçük olamaz !");
            RuleFor(x => x.CategoryName).MaximumLength(15).WithMessage("Kategori adı 15 karakterden büyük olamaz !");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş olamaz !");
            RuleFor(x => x.CategoryDescription).MinimumLength(10).WithMessage("Kategori açıklaması 10 karakterden küçük olamaz !");
            RuleFor(x => x.CategoryDescription).MaximumLength(130).WithMessage("Kategori açıkalaması 130 karakterden büyük olamaz !");
        }
    }
}
