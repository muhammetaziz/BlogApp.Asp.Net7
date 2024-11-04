using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class User
    {
        
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }


        #region Relation

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        #endregion
    }
}
