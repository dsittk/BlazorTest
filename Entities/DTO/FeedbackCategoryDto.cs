using System;

namespace Entities.DTO
{
    public class FeedbackCategoryDto
    {
        public bool AllowPostpone { get; set; }
        public Guid Id { get; set; }
        public bool IsCancellation { get; set; }
        public string Name { get; set; } = null!;
        public bool UseWithOther { get; set; }
        public bool UseWithRdv { get; set; }
    }
}