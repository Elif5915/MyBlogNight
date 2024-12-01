using Microsoft.Extensions.DependencyInjection;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.Concrete;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.EntityFramework;

namespace MyBlogNight.BusinessLayer.Container;
public static class Extensions
{
    public static void ContainerDependencies(this IServiceCollection services) //buradaki this service it olan her şeyi erişebilmemi sağlıyor.yani program cs de ContainerDependencies erişebilmem için this gerekli.
    {
        services.AddScoped<IArticleDal, EfArticleDal>();
        services.AddScoped<IArticleService, ArticleManager>();

        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICategoryService, CategoryManager>();

        services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();

        services.AddScoped<ICommentDal, EfCommentDal>();
        services.AddScoped<ICommentService, CommentManager>();
    }

}

