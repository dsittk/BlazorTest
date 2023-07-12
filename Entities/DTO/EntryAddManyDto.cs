using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTO
{
    /// <summary>
    /// Les données permettant l'ajout de plusieurs entrées
    /// </summary>
    public class EntryAddManyDto
    {
        public EntryAddManyDto()
        {
            this.Days = new List<int>();
            this.CalendarsId = new List<Guid>();
        }

        /// <summary>
        /// Gets or sets la liste des identifiants des calendriers pour lesquels on fait l'ajout de l'entrée.
        /// </summary>
        [Required]
        public IEnumerable<Guid> CalendarsId { get; set; }

        /// <summary>
        /// Le numéro des jours de la semaine pour lesquels on ajoute l'entrée.
        /// </summary>
        /// <remarks>0 pour dimanche, 1 pour lundi, etc...</remarks>
        [Required]
        public IEnumerable<int> Days { get; set; }

        /// <summary>
        /// Gets or sets la durée de l'entrée (en heure).
        /// </summary>
        public float Duration { get; set; }

        /// <summary>
        /// Gets or sets la date de fin.
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets l'entrée de la catégorie.
        /// </summary>
        [Required]
        public Guid EntryCategoryId { get; set; }

        /// <summary>
        /// Gets or sets la date de début.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets l'heure de début.
        /// </summary>
        [Required]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets le nom de l'utilisateur qui ajoute les entrées.
        /// </summary>
        public string UserName { get; set; } = null!;
    }
}