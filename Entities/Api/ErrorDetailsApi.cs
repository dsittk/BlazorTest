using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Api
{
    /// <summary>
    /// Erreur retournée par les api rest.
    /// </summary>
    public class ErrorDetailsApi
    {
        public ErrorDetailsApi(string message)
        {
            this.Message = message;
        }
        /// <summary>
        /// Obtient ou définit le message de l'erreur.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Obtient ou définit le status code.
        /// </summary>
        /// <example>401, 403, 500</example>
        public int StatusCode { get; set; }
    }
}
