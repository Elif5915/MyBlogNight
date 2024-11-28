using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.Abstract;
public interface IArticleService : IGenericService<Article>
{
    public List<Article> TArticleListWithCategory();
    public List<Article> ArticleListWithCategoryAndAppUser();
    public Article TArticleListWithCategoryAndAppUserByArticleId(int id);
    public void TArticleViewCountIncrease(int id);
}
