using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(10)]
        public string FirstName { get; set; }
        [MaxLength(10)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
