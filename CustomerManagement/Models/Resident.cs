using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Resident : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
