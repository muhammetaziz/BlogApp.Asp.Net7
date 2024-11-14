using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }

         

        void PostAdd(Post post); 
        void PostUpdate(Post post);
        void PostDelete(Post post);
         

    }
}
