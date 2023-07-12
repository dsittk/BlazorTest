using System;

namespace Entities.DTO
{
    /// <summary>
    /// Données necessaire au calcul de la disponibilité d'une entrée libre.
    /// </summary>
    public class EntryFreeDto
    {
        /// <summary>
        /// Get or set la durée de l'entrée.
        /// </summary>
        public float Duration { get; set; }

        /// <summary>
        /// Get or set le début de l'entrée.
        /// </summary>
        public DateTime Start { get; set; }
    }
}