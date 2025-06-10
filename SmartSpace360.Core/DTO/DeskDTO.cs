using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpace360.Core.DTO
{
    public class DeskDTO
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
        public int RoomId { get; set; }
    }
}
