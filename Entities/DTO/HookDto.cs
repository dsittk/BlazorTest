using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public class HookDto
    {
        public Guid CalendarId { get; set; }
        public bool OnCreate { get; set; }
        public bool OnDelete { get; set; }
        public bool OnFeedback { get; set; }
        public bool OnUpdate { get; set; }

        [Required]
        public string UrlToCall { get; set; } = null!;

        public Guid Id { get; set; }
    }
}
