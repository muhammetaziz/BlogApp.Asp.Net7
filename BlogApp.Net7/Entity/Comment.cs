using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }


        #region Relation

        public int PostId { get; set; }
        public Post Post { get; set; } = null!;



        public int UserId { get; set; }
        public User User { get; set; } = null!;

        #endregion
    }
}
