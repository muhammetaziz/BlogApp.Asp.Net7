using BlogApp.Net7.Entity;

namespace BlogApp.Net7.Models
{
    public class PostViewModel
    {

        public List<Post> Posts { get; set; } = new();
        public List<Tag> Tags { get; set; } = new();
    }
}
