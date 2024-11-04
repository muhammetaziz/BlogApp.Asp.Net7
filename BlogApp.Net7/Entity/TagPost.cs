namespace BlogApp.Net7.Entity
{
    public class TagPost
    {
         
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;


        public int TagId { get; set; }
        public Tag Tag { get; set; } = null!;

    }
}
