using Blog.Entity;

namespace Blog.Data.Abstract{

    public interface ICommentRepository{

        IQueryable<Comment> Comments { get; }

        void CreateComment(Comment comment);
    }
}