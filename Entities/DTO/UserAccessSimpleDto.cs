using System;

namespace Entities.DTO
{
    /// <summary>
    /// Informations sur un accès utilisateur.
    /// </summary>
    public class UserAccessSimpleDto
    {
        /// <summary>
        /// Obtient ou définit le nom de l'accès.
        /// </summary>
        /// <example>
        /// - Agenda "Region NORD"
        /// - Donneur d'ordre "Ma société"
        /// </example>
        public string AccessName { get; set; } = null!;

        /// <summary>
        /// Obtient ou définit l'identifiant de l'accès.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si l'accès est actif.
        /// </summary>
        /// <value>
        ///   <c>true</c> si l'accès est actif; sinon, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du profil lié à l'accès.
        /// </summary>
        public string? ProfileName { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'utilisateur sur lequel porte l'accès.
        /// </summary>
        public string? UserName { get; set; }
    }
}