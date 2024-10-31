using Microsoft.EntityFrameworkCore;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.Context;
public class BlogContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<TagCloud> TagClouds { get; set; }

}

