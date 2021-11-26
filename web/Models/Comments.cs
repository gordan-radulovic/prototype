using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace web.Models{
    public class Comments{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommentID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public int UserID { get; set; }
        [ForeignKey(nameof(PostID))]
        public int PostID { get; set; }
        public string? Content { get; set; }
        public DateTime PostTime { get; set; }

        ApplicationUser userManager;
        public Comments(){
            PostTime = DateTime.Now;
        }

    }
    
}

