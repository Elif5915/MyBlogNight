using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.EntityFramework;
public class EfCommentDal : GenericRepository<Comment>, ICommentDal
{
    public EfCommentDal(BlogContext context) : base(context)
    {
    }

    public List<Comment> GetCommentsByArticleId(int id)
    {
        var context = new BlogContext();
        var value = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).ToList();
        return value;
    }
}

