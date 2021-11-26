using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace web.Models{
    public class Posts{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostID { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public int UserID { get; set; }
        public string? Content { get; set; }
        public DateTime PostTime { get; set; }

        ApplicationUser userManager;
        public Posts(){
            PostTime = DateTime.Now;
        }

    }
    
}

