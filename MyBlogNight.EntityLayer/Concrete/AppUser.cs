using Microsoft.AspNetCore.Identity;

namespace MyBlogNight.EntityLayer.Concrete;
public class AppUser : IdentityUser<int>
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string ImageUrl { get; set; }
    public List<Article> Articles { get; set; }
    public List<Comment> Comments { get; set; }
}

