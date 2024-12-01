using FluentValidation;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules;
public class CreateCategoryValidator : AbstractValidator<Category>
{
	public CreateCategoryValidator()
	{
		RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori adını boş bırakmayınız."); //boş geçilemez kategori name eğer boş geçmek istenirse kullanıcıya uyarı mesajı veriyoruz.
		RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız!");
		RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız.");
	}
}

