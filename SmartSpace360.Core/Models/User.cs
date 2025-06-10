using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Hashed password

        public int RoleId { get; set; }
        public Role? Role { get; set; }

        public ICollection<Booking>? Bookings { get; set; }

    }
}
