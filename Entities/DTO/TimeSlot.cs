using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class TimeSlot
    {
        public TimeSlot()
        {
            this.CalendarsId = new List<Guid>();
        }

        /// <summary>
        /// Gets or sets les identifiants de calendriers qui ont la plage horaire de disponible.
        /// </summary>
        public IEnumerable<Guid> CalendarsId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the time slot is free.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this time slot is free; otherwise, <c>false</c>.
        /// </value>
        public bool IsFree { get; set; }

        /// <summary>
        /// Gets or sets le début de la plage horaire.
        /// </summary>
        /// <remarks>La fin de la plage horaire dépend de la configuration de la campagne.</remarks>
        public DateTime Start { get; set; }
    }
}