using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public int BlogTypeId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("BlogTypeId")]
        public BlogType BlogType { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
