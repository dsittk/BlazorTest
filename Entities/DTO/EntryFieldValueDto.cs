using System;

namespace Entities.DTO
{
    public class EntryFieldValueDto
    {
        /// <summary>
        /// Gets or sets the entry field identifier.
        /// </summary>
        public Guid? EntryFieldId { get; set; }

        /// <summary>
        /// Gets or sets the name of the entry field.
        /// </summary>
        public string? EntryFieldName { get; set; }

        /// <summary>
        /// Gets or sets the value of the field.
        /// </summary>
        public string? Value { get; set; }
    }
}