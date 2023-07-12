using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class CampaignSimpleDto
    {        
        public CampaignSimpleDto()
        {
            this.CalendarsName = new List<string>();
        }

        public IEnumerable<string> CalendarsName { get; set; }
        public float DefaultRdvDuration { get; set; }
        public string? Description { get; set; }
        public int DistributionMethod { get; set; }
        public DateTime End { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Prompt { get; set; }
        public string? RelativeUrl { get; set; }
        public DateTime Start { get; set; }
    }
}