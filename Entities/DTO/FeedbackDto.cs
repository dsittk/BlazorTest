using System;

namespace Entities.DTO
{
    public class FeedbackDto
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
        public Guid EntryId { get; set; }
        public Guid FeedbackCategoryId { get; set; }
        public FeedbackCategoryDto? FeedbackCategory { get; set; }
        public Guid Id { get; set; }
        public string? Reason { get; set; }
    }
}