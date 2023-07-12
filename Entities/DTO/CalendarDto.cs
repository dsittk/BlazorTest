using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    /// <summary>
    /// Données d'un calendrier.
    /// </summary>
    public class CalendarDto
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du calendier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtient ou définit l'URL de l'image
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Obtient ou définit le nom.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Obtient ou définit l'identifiant du donneur d'ordre.
        /// </summary>
        public Guid OriginatorId { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du donneur d'ordre.
        /// </summary>
        public string? OriginatorName { get; set; }
    }
}
