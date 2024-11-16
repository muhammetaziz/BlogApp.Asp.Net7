using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public enum TagColors
    {
        primary, secondary, danger, warning, success
    }
    public class Tag
    {
        
        public int TagId { get; set; }
        public string? Text { get; set; }
        public TagColors? Color { get; set; }

        public string? Url { get; set; }



        #region Relation


        public ICollection<TagPost> TagPosts { get; set; } = new List<TagPost>();
        public List<Post> Posts { get; set; }=new List<Post>();
        #endregion




    }
}
