using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.Abstract;
public interface IArticleDal : IGenericDal<Article>
{
	List<Article> ArticleListWithCategory();
	List<Article> ArticleListWithCategoryAndAppUser();
	Article ArticleListWithCategoryAndAppUserByArticleId(int id);
	void ArticleViewCountIncrease(int id); //blogun detay id si alıyor
	List<Article> GetArticlesByAppUserId(int id);
}
