using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.EntityFramework;
public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(BlogContext context) : base(context)
    {
    }
}

