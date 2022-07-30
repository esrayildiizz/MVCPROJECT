using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //CategoryName boş olamaz.Ve bu mesaj önümüze gelir.
            RuleFor(x => x. WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            //CategoryDescription boş olamaz.Ve bu mesaj önümüze gelir.
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz.");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Geçemezsiniz.");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karater girişi yapınız.");
            
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın.");


        }
    }
    
}
