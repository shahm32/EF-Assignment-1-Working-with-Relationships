using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public int PostTypeId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        [ForeignKey("PostTypeId")]
        public PostType PostType { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
