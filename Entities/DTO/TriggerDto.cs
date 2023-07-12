using Entities.Enums;

namespace Entities.DTO
{
    public class TriggerDto
    {
        public Guid? CalendarId { get; set; }
        public float EntryStartSendingDelay { get; set; }
        public EventType EventType { get; set; }
        public Guid Id { get; set; }
        public Guid? OriginatorId { get; set; }
        public TimeSpan? SendingTimeEnd { get; set; }

        public TimeSpan? SendingTimeStart { get; set; }

        public Guid? TargetEntryCategoryId { get; set; }

        public Guid? TargetFeedbackCategoryId { get; set; }

        /// <summary>
        /// Gets or sets les identifiants des profils reliés à la notification.
        /// Correspond au profil AuthenticationCore.
        /// </summary>
        public IEnumerable<Guid> TargetProfilesId { get; set; } = null!;

        public Guid TemplateId { get; set; }
    }
}