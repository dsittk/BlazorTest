using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class EntryCategoryDto
    {
        public string? WebColor { get; set; }
        public string Name { get; set; } = null!;
        public Guid Id { get; set; }
        public bool IsRdv { get; set; }
    }
}
