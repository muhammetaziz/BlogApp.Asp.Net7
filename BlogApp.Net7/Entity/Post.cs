using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool IsActive { get; set; }

        #region Relation

        public int UserId { get; set; }
        public User User { get; set; } = null!;


        public List<Tag> Tags { get; set; }= new List<Tag>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

        #endregion

    }
}
