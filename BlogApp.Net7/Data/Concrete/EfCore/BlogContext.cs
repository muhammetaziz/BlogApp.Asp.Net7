using BlogApp.Net7.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BlogApp.Net7.Data.Concrete.EfCore
{
    public class BlogContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Post ve Tag arasında many-to-many ilişki için ara tablo yapılandırması
            modelBuilder.Entity<TagPost>()
                .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<TagPost>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.TagPosts)
                .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<TagPost>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.TagPosts)
                .HasForeignKey(pt => pt.TagId);

            // Comment tablosundaki cascade ayarları
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<TagPost> TagPosts => Set<TagPost>();
        public DbSet<Subscribe> Subscribe => Set<Subscribe>();
    }
}
