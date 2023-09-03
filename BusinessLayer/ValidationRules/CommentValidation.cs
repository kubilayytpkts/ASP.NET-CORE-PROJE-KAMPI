using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidation:AbstractValidator<Comment>
    {
        public CommentValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen İsim Soyisim giriniz !");
            RuleFor(x => x.CommentTitle).NotEmpty().WithMessage("Lütfen bir konu giriniz !");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Lütfen Göndermek Mesajınızı giriniz !");
        }
    }
}
