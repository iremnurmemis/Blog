using Blog.Data.Abstract;
using Blog.Data.Concrete.EfCore;
using Blog.Entity;

namespace Blog.Data.Concrete{

    public class EfTagRepository : ITagRepository
    {
        private BlogContext _context;
        public EfTagRepository(BlogContext context)
        {
            _context=context;
        }
        public IQueryable<Tag> Tags => _context.Tags;

        public void CreateTag(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }
    }
}