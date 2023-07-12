using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class ConstraintDto
    {
        public ConstraintDto()
        {
            this.DaysOfWeek = new List<int>();
        }

        public bool BlockHoliday { get; set; }
        public Guid CalendarId { get; set; }
        public bool CanCreateOther { get; set; }
        public bool CanCreateRdv { get; set; }
        public IEnumerable<int> DaysOfWeek { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime? From { get; set; }
        public float Granularity { get; set; }
        public int MaximumDayRdv { get; set; }
        public int MaximumRdvConflicts { get; set; }

        /// <summary>
        /// Gets or sets the duration of the RDV.
        /// </summary>
        public float RdvDuration { get; set; }

        public TimeSpan StartTime { get; set; }
        public int? TargetedWeek { get; set; }
        public int? TargetedYear { get; set; }
        public DateTime? To { get; set; }
        public bool UseListForCity { get; set; }
    }
}