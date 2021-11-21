using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models{
    public class Posts{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public String Content { get; set; }
        public DateTime PostTime { get; set; }
    }
}

