using System;

namespace Entities.DTO
{
    public class CampaignTokenDto
    {
        /// <summary>
        /// Gets or sets the campaign identifier.
        /// </summary>
        public Guid CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the date end validity.
        /// </summary>
        public DateTime DateEndValidity { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the phone of the user.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets le token permettant de vérifier si un utilisateur peut ajouter une entrée sur une campagne.
        /// Utilisé par le client pour s'authentifier.
        /// </summary>
        public Guid Token { get; set; }
    }
}