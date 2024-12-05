using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.Abstract;
public interface ICommentService : IGenericService<Comment>
{
    public List<Comment> TGetCommentsByArticleId(int id);
    public List<Comment> TGetCommentsByAppUserId(int id);
}
