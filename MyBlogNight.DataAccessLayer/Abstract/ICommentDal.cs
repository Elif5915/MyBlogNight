using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.DataAccessLayer.Abstract;
public interface ICommentDal : IGenericDal<Comment>
{
    List<Comment> GetCommentsByArticleId(int id);
}
