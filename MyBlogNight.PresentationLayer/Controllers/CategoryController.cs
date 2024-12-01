using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers;
public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IActionResult CategoryList()
    {
        var values = _categoryService.TGetAll();
        return View(values);
    }

    [HttpGet]
    public IActionResult CreateCategory()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        ModelState.Clear(); //defaultta data annotion kontrolleri devreye giriyor.bu satırdaki kod ile hafızadaki tüm annationlerı hafızadan silip kendi kurallarım ve sonuçlarımı işleme koyuyorum.

        CreateCategoryValidator validationRules = new CreateCategoryValidator(); //CreateCategoryValidator sınıfımızdan validationRules isminde bir nesne örnekledik.
        ValidationResult result = validationRules.Validate(category); //burada demek istedişğimiz category paramteresinden gelen değerleri validate et,yani kontrol et
        if (result.IsValid) //eğer işlemler validasyona takılmıyorsa ekleme yapsın.
        {
            _categoryService.TInsert(category);
            return RedirectToAction("CategoryList");
        }
        else //eğer takılmışsa hata ver
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage); //PropertyName hataya sebep olan property miz,ErrorMessage ise  CreateCategoryValidator sınıfındaki withmessage olarak tanımladıklarımız.
            }
            return View();
        }

    }

    public IActionResult DeleteCategory(int id)
    {
        _categoryService.TDelete(id);
        return RedirectToAction("CategoryList");
    }

    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
        var value = _categoryService.TGetById(id);
        return View(value);
    }
    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {
        _categoryService.TUpdate(category);
        return RedirectToAction("CategoryList");
    }
}
