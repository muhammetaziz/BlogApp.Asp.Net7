using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? SubMail { get; set; }
        public DateTime SubDate { get; set; }
        public bool Active { get; set; }
    }
}
