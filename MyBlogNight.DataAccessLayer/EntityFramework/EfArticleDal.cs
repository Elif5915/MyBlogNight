﻿using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.EntityFramework;
public class EfArticleDal : GenericRepository<Article>, IArticleDal
{
    public EfArticleDal(BlogContext context) : base(context)
    {
    }
}
