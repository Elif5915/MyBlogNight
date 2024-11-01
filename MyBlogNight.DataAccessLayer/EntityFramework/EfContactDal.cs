using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.EntityFramework;
public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    public EfContactDal(BlogContext context) : base(context)
    {
    }
}

