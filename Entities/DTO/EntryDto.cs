﻿using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class EntryDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryDto"/> class.
        /// </summary>
        /// <autogeneratedoc />
        public EntryDto()
        {
            this.EntryFieldValues = new List<EntryFieldValueDto>();
            this.CreatedBy = null!;
        }

        public AddressBlockDto? AddressBlock { get; set; }
        public Guid CalendarId { get; set; }
        public string? CalendarName { get; set; }
        public Guid? CampaignToken { get; set; }
        public string? CampaignName { get; set; }
        public string CreatedBy { get; set; }
        public string? Description { get; set; }
        public float Duration { get; set; }
        public string? Email { get; set; }
        public Guid EntryCategoryId { get; set; }
        public string? EntryCategoryName { get; set; }
        public IEnumerable<EntryFieldValueDto> EntryFieldValues { get; set; }
        public FeedbackDto? Feedback { get; set; }
        public Guid Id { get; set; }
        public bool? IsRdv { get; set; }
        public Guid? NextEntryId { get; set; }
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets l'identifiant de la précédente entrée. Dans le cas d'une report d'entrée.
        /// N'existe pas en base.
        /// </summary>
        public Guid? PreviousEntryId { get; set; }

        public DateTime? Start { get; set; }
        public string? StaticDescription { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? WebColor { get; set; }
    }
}