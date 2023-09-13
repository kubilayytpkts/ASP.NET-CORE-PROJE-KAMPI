using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class BlogValidation:AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı boş geçilemez !");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığı en az 5 karakter olmalı !");
            RuleFor(x => x.BlogTitle).MaximumLength(30).WithMessage("Blog Başlığı 30 karakterden büyük olamaz !");
            RuleFor(x => x.BlogTitle).NotEmpty().MinimumLength(50).WithMessage("Geçersiz Blog başlığı !");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Yazısı boş Geçilemez !");
            RuleFor(x => x.BlogContent).MinimumLength(30).WithMessage("Yazınız en az 30 karakter içermeli !");
            RuleFor(x => x.BlogContent).MaximumLength(1000).WithMessage("Yazının 1000 karakteri geçemez !");
        }
    }
}
