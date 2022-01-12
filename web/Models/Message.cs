using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace web.Models{
    public class Message{
        public int ID { get; set;}
        public String Name { get; set; }
        public String Text { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}