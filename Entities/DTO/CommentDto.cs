using System;

namespace Entities.DTO
{
    public class CommentDto
    {
        public string Body { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; } = null!;

        public Guid EntryId { get; set; }

        public Guid Id { get; set; }
    }
}