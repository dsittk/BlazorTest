using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    /// <summary>
    /// Champ dynamique associable à une catégorie d'entrée et à un calendrier.
    /// </summary>
    public class EntryFieldDto
    {
        public EntryFieldDto()
        {
            this.EntryFieldListItems = new List<EntryFieldListItemDto>();
            this.Name = null!;
        }

        /// <summary>
        /// Gets or sets the date maximum.
        /// </summary>
        public DateTime? DateMax { get; set; }

        /// <summary>
        /// Gets or sets the date minimum.
        /// </summary>
        public DateTime? DateMin { get; set; }

        /// <summary>
        /// Gets or sets the entry field list items.
        /// </summary>
        public IEnumerable<EntryFieldListItemDto> EntryFieldListItems { get; set; }

        /// <summary>
        /// Gets or sets the type of the field.
        /// </summary>
        public string FieldType { get; set; } = null!;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is mandatory.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is mandatory; otherwise, <c>false</c>.
        /// </value>
        public bool IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets the mask. The mask should be a REGEX.
        /// </summary>
        public string? Mask { get; set; }

        /// <summary>
        /// Gets or sets the number maximum.
        /// </summary>
        public float? Max { get; set; }

        /// <summary>
        /// Gets or sets the number minimum.
        /// </summary>
        public float? Min { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the possible entry category identifier.
        /// </summary>
        public Guid? PossibleEntryCategoryId { get; set; }
    }
}