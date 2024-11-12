using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class User
    {
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakılamaz")]
        [DisplayName("Kullanıcı Adı")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Kullanıcı Soyadı boş bırakılamaz")]
        [DisplayName("Kullanıcı Soyadı")]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Resmi boş bırakılamaz")]
        [DisplayName("Kullanıcı Resim")]
        public string? UImage { get; set; }
        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [DisplayName("Şifre")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "E-Mail boş bırakılamaz")]
        [DisplayName("E-Mail")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Telefon boş bırakılamaz")]
        [DisplayName("Telefon")]
        public string? Phone { get; set; }


        #region Relation

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        #endregion
    }
}
