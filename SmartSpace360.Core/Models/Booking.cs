using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public int? RoomId { get; set; }
        public int? DeskId { get; set; }

        public User? User { get; set; }
        public Room? Room { get; set; }
        public Desk? Desk { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; } = "Pending";
    }
}
