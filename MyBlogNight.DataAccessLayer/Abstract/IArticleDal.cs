using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.Abstract;
public interface IArticleDal : IGenericDal<Article>
{
    List<Article> ArticleListWithCategory();
    List<Article> ArticleListWithCategoryAndAppUser();
}
