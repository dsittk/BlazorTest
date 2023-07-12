using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Api
{
    public class UserResetPasswordApi
    {
        /// <summary>
        /// Gets or sets l'email de l'utilisateur.
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or sets le token permettant de reset le mot de passe de l'utilisateur.
        /// </summary>
        [Required]
        public string Token { get; set; } = null!;
    }
}
