using Blog.Entity;

namespace Blog.Data.Abstract{

    public interface IPostRepository{

        IQueryable<Post> Posts { get; }

        void CreatePost(Post post);

        void Edit(Post post);
    }
}