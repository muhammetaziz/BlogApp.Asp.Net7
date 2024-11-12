using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }



        void UserAdd(User user);
        void UserUpdate(User user);
        void UserDelete(User user);
    }
}
