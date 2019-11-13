using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class TeaOrderTea
    {
        public Guid TeaOrderId { get; set; }
        public TeaOrder TeaOrder { get; set; }

        public Guid TeaId { get; set; }
        public Tea Tea { get; set; }
    }
}
