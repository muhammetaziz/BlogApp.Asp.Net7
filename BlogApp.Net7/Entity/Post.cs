using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Post
    {
        #region Entities

        public int PostId { get; set; }


        [DisplayName(displayName: "Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz")]
        public string? Title { get; set; }
        
        
        [DisplayName(displayName: "İçerik")]
        [Required(ErrorMessage = "İçerik boş bırakılamaz")]
        [MinLength(150)]
        public string? Content { get; set; }

        public string? Url { get; set; }


        [Required(ErrorMessage = "Resim boş bırakılamaz")]
        [DisplayName(displayName: "Resim")]
        public string? PImage { get; set; }
        
        
        [DisplayName(displayName: "Eklenme Tarihi")]
        public DateTime PublishedOn { get; set; }
        
        
        [DisplayName(displayName: "Aktif/Pasif")]
        public bool IsActive { get; set; }
        #endregion

        #region Relation

        public int UserId { get; set; }
        public User User { get; set; } = null!;


        public ICollection<TagPost> TagPosts { get; set; } = new List<TagPost>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
          
        #endregion

    }
}
