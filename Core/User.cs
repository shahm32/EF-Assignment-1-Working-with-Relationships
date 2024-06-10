using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User: BaseEntity
    {
        //public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        
    }
}
