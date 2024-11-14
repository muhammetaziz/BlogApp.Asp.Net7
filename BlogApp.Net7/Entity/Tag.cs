using System.ComponentModel.DataAnnotations;

namespace BlogApp.Net7.Entity
{
    public class Tag
    {
        
        public int TagId { get; set; }
        public string? Text { get; set; }

        public string? Url { get; set; }



        #region Relation


        public ICollection<TagPost> TagPosts { get; set; } = new List<TagPost>();
        #endregion
        



    }
}
