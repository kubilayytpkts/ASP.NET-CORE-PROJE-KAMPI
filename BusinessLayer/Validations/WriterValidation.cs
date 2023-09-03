using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class WriterValidation : AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim boş geçilemez !");
            RuleFor(x => x.WriterName).MinimumLength(1).WithMessage("Geçersiz isim");
            RuleFor(x => x.WriterName).Must(x => !x.Any(char.IsDigit)).WithMessage("İsim içerisinde rakam olamaz !");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim 50 karakterden fazla olamaz");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifreniz kısmı boş olamaz !");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Şifreniz 8 haneden küçük olamaz !");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Şifreniz 15 haneden büyük olamaz !");
            RuleFor(x => x.WriterPassword).Must(password => password.Any(char.IsUpper)).WithMessage("Şifrenizde en az bir büyük harf içermeli !");
            RuleFor(x => x.WriterPassword).Must(password => password.Any(char.IsDigit)).WithMessage("Şifrenizde en az bir rakam içermeli !");
            RuleFor(x => x.WriterPassword).Must(password => password.Any(char.IsPunctuation)).WithMessage("Şifreniz en az bir noktalama işareti içermeli !");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail adresi boş olamaz");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçersiz E-mail adresi !");
            RuleFor(x => x.WriterMail).MinimumLength(10).WithMessage("Geçersiz E-mail adresi !");
            RuleFor(x => x.WriterMail).MaximumLength(30).WithMessage("Geçersiz E-mail adresi !");
        }
    }
}
