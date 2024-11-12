using BlogApp.Net7.Data.Abstract;
using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Concrete.EfCore
{
    public class EfUserRepository : IUserRepository
    {
        BlogContext _context;

        public EfUserRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<User> Users => _context.Users;
        public void UserAdd(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UserDelete(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

        public void UserUpdate(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
