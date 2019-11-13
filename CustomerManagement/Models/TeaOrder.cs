using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class TeaOrder : BaseModel
    {
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public IList<TeaOrderTea> TeaOrderTeas { get; set; }
    }
}
