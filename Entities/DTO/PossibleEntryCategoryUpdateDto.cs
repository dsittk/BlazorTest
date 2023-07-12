using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class PossibleEntryCategoryUpdateDto
    {
        public PossibleEntryCategoryUpdateDto()
        {
            this.EntryFields = new List<EntryFieldDto>();
            this.CalendarsId = new List<Guid>();
        }

        public int AddressBlockLevel { get; set; }
        public IEnumerable<Guid> CalendarsId { get; set; }

        /// <summary>
        /// Gets or sets the campaign identifier.
        /// Si renseigné met à jour les contraintes des contributions des calendriers renseignés.
        /// </summary>
        public Guid? CampaignId { get; set; }

        public int DescriptionLevel { get; set; }
        public int EmailLevel { get; set; }
        public Guid EntryCategoryId { get; set; }
        public IEnumerable<EntryFieldDto> EntryFields { get; set; }
        public bool IsActive { get; set; }
        public int PhoneLevel { get; set; }
    }
}