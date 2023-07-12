namespace Entities.DTO
{
    /// <summary>
    /// Mise à jour d'un contrainte.
    /// </summary>
    public class ConstraintsUpdateDto
    {
        public ConstraintsUpdateDto()
        {
            this.CalendarsId = new List<Guid>();
            this.DaysOfWeek = new List<int>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether holiday must be block.
        /// </summary>
        /// <value>
        ///   <c>true</c> if holiday must be block; otherwise, <c>false</c>.
        /// </value>
        public bool BlockHoliday { get; set; }

        /// <summary>
        /// Gets or sets the calendars identifier.
        /// </summary>
        public IEnumerable<Guid> CalendarsId { get; set; }

        /// <summary>
        /// Gets or sets the campaign identifier.
        /// </summary>
        public Guid? CampaignId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can create other.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can create other; otherwise, <c>false</c>.
        /// </value>
        public bool CanCreateOther { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can create RDV.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can create RDV; otherwise, <c>false</c>.
        /// </value>
        public bool CanCreateRdv { get; set; }

        /// <summary>
        /// Gets or sets the days of week.
        /// </summary>
        /// <remarks>Sunday = 0</remarks>
        public IEnumerable<int> DaysOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Gets or sets first date of the calendar.
        /// </summary>
        public DateTime? From { get; set; }

        /// <summary>
        /// Gets or sets the granularity.
        /// </summary>
        public float Granularity { get; set; }

        /// <summary>
        /// Gets or sets the maximum day RDV.
        /// </summary>
        public int MaximumDayRdv { get; set; }

        /// <summary>
        /// Gets or sets the maximum RDV conflicts.
        /// </summary>
        public int MaximumRdvConflicts { get; set; }

        /// <summary>
        /// Gets or sets the duration of the RDV.
        /// </summary>
        public float RdvDuration { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets the targeted week.
        /// </summary>
        public int? TargetedWeek { get; set; }

        /// <summary>
        /// Gets or sets the targeted year.
        /// </summary>
        public int? TargetedYear { get; set; }

        /// <summary>
        /// Gets or sets last date of the calendar.
        /// </summary>
        public DateTime? To { get; set; }

        public bool UseListForCity { get; set; }
    }
}