using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.EntityFramework;
public class EfTagCloudDal : GenericRepository<TagCloud>, ITagCloudDal
{
    public EfTagCloudDal(BlogContext context) : base(context)
    {
    }
}

