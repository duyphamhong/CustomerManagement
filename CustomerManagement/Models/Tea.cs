using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Tea : BaseModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qauntity { get; set; }
    }
}
