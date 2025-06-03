using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.Models
{
    public class Desk
    {
            public int Id { get; set; }

            [Required, StringLength(50)]
            public string Code { get; set; }

            [Required]
            public bool IsAvailable { get; set; }

            [Required]
            public int RoomId { get; set; }

            public Room? Room { get; set; }

            public ICollection<Booking>? Bookings { get; set; }
    }
}
