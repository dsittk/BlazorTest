using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class PossibleFeedbackCategoryDto
    {
        public Guid CalendarId { get; set; }
        public bool AllowPostpone { get; set; }
        public Guid FeedbackCategoryId { get; set; }
        public Guid Id { get; set; }
    }
}
