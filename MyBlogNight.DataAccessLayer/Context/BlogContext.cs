using Microsoft.EntityFrameworkCore;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.Context;
public class BlogContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=NETCADYAZ; initial catalog=BlogFoodyDb;integrated security= true;");
    }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<TagCloud> TagClouds { get; set; }

}

