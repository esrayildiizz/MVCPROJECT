using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public  class CategoryValidatior: AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            //CategoryName boş olamaz.Ve bu mesaj önümüze gelir.
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Alanını Boş Geçemezsiniz.");

            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karater girişi yapınız.");

            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın.");


        }
    }
}
