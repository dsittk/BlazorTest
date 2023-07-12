using System;
using System.Collections.Generic;

namespace Entities.DTO
{
    public class CampaignDto
    {
        public CampaignDto()
        {
            this.CalendarsId = new List<Guid>();
        }

        public IEnumerable<Guid> CalendarsId { get; set; }
        public float DefaultRdvDuration { get; set; }
        public string? Description { get; set; }
        public int DistributionMethod { get; set; }
        public DateTime End { get; set; }
        public Guid Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets l'identifiant du donneur d'ordre des calendriers.
        /// </summary>
        public Guid? OriginatorId { get; set; }

        /// <summary>
        /// Gets or sets le nom du donneur d'ordre des calendriers.
        /// </summary>
        public string? OriginatorName { get; set; }

        public string? Prompt { get; set; }

        public string? RelativeUrl { get; set; }

        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets l'identifiant d'un template document generator permettant une notification par mail du RDV.
        /// La notification est faite si le template est renseigné.
        /// </summary>
        public Guid? TemplateEmailId { get; set; }

        /// <summary>
        /// Gets or sets l'identifiant d'un template document generator permettant une notification par SMS du RDV.
        /// La notification est faite si le template est renseigné.
        /// </summary>
        public Guid? TemplateSmsId { get; set; }

        /// <summary>
        /// Gets or sets le temps avant la prise d'un nouveau RDV (par rapport à la date actuelle).
        /// </summary>
        public int TimeBeforeNewRdv { get; set; }

        /// <summary>
        /// Gets or sets le nombre d'heure avant la date du rendez-vous à laquelle renvoyer les notifications.
        /// </summary>
        public int? TimeBeforeRappelNotification { get; set; }
    }
}