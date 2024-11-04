using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Post
    {
        
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool IsActive { get; set; }

        #region Relation

        public int UserId { get; set; }
        public User User { get; set; } = null!;


        public ICollection<TagPost> TagPosts { get; set; }= new List<TagPost>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        #endregion

    }
}
