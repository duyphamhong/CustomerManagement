using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public ICollection<TeaOrder> Orders { get; set; }
    }
}
