using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Blog: BaseEntity
    {
        //public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public int BlogTypeId { get; set; }

        public BlogType BlogType { get; set; }
    }
}
