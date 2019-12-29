using CustomerManagement.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Car : BaseModel
    {
        public string CarIdentity { get; set; }
        public CarType Type { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
