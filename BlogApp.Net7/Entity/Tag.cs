using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string? Text { get; set; }
      
        
        
        
        #region Relation

        public List<Post> Posts { get; set; } = new List<Post>();
        #endregion
        



    }
}
