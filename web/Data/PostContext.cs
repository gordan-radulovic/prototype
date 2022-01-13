using web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public class PostContext : IdentityDbContext<ApplicationUser>
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments {get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Posts>().HasKey(p => new {p.PostID});
            modelBuilder.Entity<Posts>().ToTable("Posts");

            modelBuilder.Entity<Comments>(c=>{
                c.Property<int>("CommentID");
                c.HasKey("CommentID");
                });
            modelBuilder.Entity<Comments>().ToTable("Comments");
        }
    }
}