using CustomerManagement.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Customer : BaseModel
    {
        [Required]
        [StringLength(20)]
        [NameValidation("D")]
        public string Name { get; set; }
        [Required]
        [Range(18,40)]
        public int Age { get; set; }
        public ICollection<TeaOrder> Orders { get; set; }
    }
}
