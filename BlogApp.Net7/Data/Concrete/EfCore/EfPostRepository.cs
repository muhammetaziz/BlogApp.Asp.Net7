using BlogApp.Net7.Data.Abstract;
using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Concrete.EfCore
{
    public class EfPostRepository : IPostRepository
    {
        private BlogContext _context;

        public EfPostRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<Post> Posts => _context.Posts;

        

        public void PostAdd(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
        public void PostDelete(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }
         
        public void PostUpdate(Post post)
        {
            _context.Update(post);
            _context.SaveChanges();
        }
    }
}
