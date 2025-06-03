using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
