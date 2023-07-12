using Entities.Enums;

namespace Entities.DTO
{
    public class TriggerFullDto
    {
        public TriggerFullDto()
        {
            this.TargetProfilesName = new List<string>();
        }

        public Guid? CalendarId { get; set; }

        //public float EntryStartSendingDelay { get; set; }
        public EventType EventType { get; set; }

        public Guid Id { get; set; }

        //public Guid Id { get; set; }
        public Guid? OriginatorId { get; set; }

        //public TimeSpan SendingTimeEnd { get; set; }

        //public TimeSpan SendingTimeStart { get; set; }
        public string? TargetCategoryColor { get; set; }

        public string? TargetEntryCategoryName { get; set; }
        public string? TargetFeedbackCategoryName { get; set; }
        public IEnumerable<string> TargetProfilesName { get; set; }
        public string TemplateName { get; set; } = null!;
    }
}