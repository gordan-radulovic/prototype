using web.Data;
using web.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PostContext context)
        {
            context.Database.EnsureCreated();

            if (context.Posts.Any())
            {
                return;   // DB has been seeded
            }

            var posts = new Posts[]
            {
                new Posts {UserID=1, PostID=1, Content="To je prva testna objava", PostTime = DateTime.Now},
                new Posts {UserID=2, PostID=2, Content="To je druga testna objava" , PostTime = DateTime.Now},
                new Posts {UserID=3, PostID=3, Content="To je trejta testna objava" , PostTime = DateTime.Now},
                new Posts {UserID=1, PostID=4, Content="To je četrta testna objava" , PostTime = DateTime.Now},
                new Posts {UserID=2, PostID=5, Content="To je peta testna objava" , PostTime = DateTime.Now}
            };

            context.Posts.AddRange(posts);
            context.SaveChanges();

            if(context.Comments.Any()){
                return;
            }

            var comments = new Comments[]
            {
                new Comments {CommentID=1, UserID=1, PostID=1, Content="To je prvi testni komentar", PostTime = DateTime.Now},
                new Comments {CommentID=2, UserID=1, PostID=2, Content="To je drugi testni komentar" , PostTime = DateTime.Now},
                new Comments {CommentID=3, UserID=1, PostID=3, Content="To je tretji testni komentar" , PostTime = DateTime.Now},
                new Comments {CommentID=4, UserID=1, PostID=4, Content="To je četrti testni komentar" , PostTime = DateTime.Now},
                new Comments {CommentID=5, UserID=1, PostID=5, Content="To je peti testni komentar" , PostTime = DateTime.Now}
            };

            context.Comments.AddRange(comments);
            context.SaveChanges();
            
        }
    }
}