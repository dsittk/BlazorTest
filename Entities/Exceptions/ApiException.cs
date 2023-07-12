using System;

namespace Entities.Exceptions
{
    /// <summary>
    /// Exception à retourner pour les exceptions liées à un appel API rest.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ApiException(string message) : base(message)
        {
        }

        /// <summary>
        /// Obtient le nom de l'exception customisée.
        /// </summary>
        public string Name { get => nameof(ApiException); }
    }
}