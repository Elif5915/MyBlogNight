using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Areas.Author.Models;

namespace MyBlogNight.PresentationLayer.Areas.Author.Controllers;

[Area("Author")]
public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> EditMyProfile()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name); //User.Identity.Name => ne bilgisi bu? oturum açan kişinin name bilgisi bu
        UserEditViewModel model = new UserEditViewModel();
        model.SurName = values.SurName;
        model.Name = values.Name;
        model.UserName = values.UserName;
        model.Email = values.Email;
        return View(model);

    }

    [HttpPost]
    public async Task<IActionResult> EditMyProfile(UserEditViewModel model)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        user.Name = model.Name;
        user.SurName = model.SurName;
        user.Email = model.Email;
        user.UserName = model.UserName;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction("CategoryList", "Category"/*, new {Area = "AreaAdı"}*/);
        }

        return View();
    }
}
