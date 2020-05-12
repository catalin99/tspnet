using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class CommentDTO
    {
        [Key]
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int PostPostId { get; set; }
        public virtual PostDTO Post { get; set; }
    }
}
