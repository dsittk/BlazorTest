using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class UserAccessDto
    {
        public string Id { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public Guid ProfileId { get; set; }
        public Guid? OriginatorId { get; set; }
        public bool IsActive { get; set; }
        public Guid? CalendarId { get; set; }
    }
}
