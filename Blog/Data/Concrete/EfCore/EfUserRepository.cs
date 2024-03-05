using Blog.Data.Abstract;
using Blog.Data.Concrete.EfCore;
using Blog.Entity;

namespace Blog.Data.Concrete{

    public class EfUserRepository : IUserRepository
    {
        private BlogContext _context;
        public EfUserRepository(BlogContext context)
        {
            _context=context;
        }
        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}