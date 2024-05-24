using HAMS.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMS.Domain.Entities
{
    public class User : IdentityUser
    {
        public UserRole Role { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public bool IsDeleted { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
