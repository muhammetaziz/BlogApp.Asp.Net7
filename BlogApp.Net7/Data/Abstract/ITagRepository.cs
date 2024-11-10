using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

         

        void TagAdd(Tag tag); 
        void TagUpdate(Tag tag);

    }
}
