using BlogApp.Net7.Data.Abstract;
using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Concrete.EfCore
{
    public class EfTagRepository : ITagRepository
    {
        private readonly BlogContext _context;

        public EfTagRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Tag> Tags => _context.Tags;

        public void TagAdd(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        public void TagUpdate(Tag tag)
        {
            _context.Tags.Update(tag);
        }
    }
}
