using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.Abstract;
public interface IArticleService : IGenericService<Article>
{
    public List<Article> TArticleListWithCategory();
}
