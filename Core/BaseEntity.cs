using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreateDateTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
