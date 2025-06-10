using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.DTO
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? RoomId { get; set; }
        public int? DeskId { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
