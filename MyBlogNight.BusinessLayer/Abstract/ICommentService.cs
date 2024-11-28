using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.BusinessLayer.Abstract;
public interface ICommentService : IGenericService<Comment>
{
    public List<Comment> TGetCommentsByArticleId(int id);
}
