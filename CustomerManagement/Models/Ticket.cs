using CustomerManagement.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Ticket : BaseModel
    {
        public Guid CarId { get; set; }
        public Car Car { get; set; }

        public Guid ResidentId { get; set; }
        public Resident Resident { get; set; }

        public DateTime ParkingStartTime { get; set; }
        public TicketType Type { get; set; }
        public bool IsMonthlyPaid { get; set; }
        public DateTime PaidUntilMonth { get; set; }
        public decimal Price { get; set; }
        public bool Deleted { get; set; }
    }
}
