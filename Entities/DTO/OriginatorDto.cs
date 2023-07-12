using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTO
{
    /// <summary>
    /// Données d'un donneur d'ordre.
    /// </summary>
    public class OriginatorDto
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du donneur d'ordre.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtient ou définit l'URL de l'image du donneur d'ordre.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du donneur d'ordre.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
    }
}