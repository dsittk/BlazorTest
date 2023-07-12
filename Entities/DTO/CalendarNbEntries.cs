namespace Entities.DTO
{
    /// <summary>
    /// Informations sur le nombre d'entrée d'un calendrier.
    /// </summary>
    public class CalendarNbEntries
    {
        /// <summary>
        /// Get or set the calendar name.
        /// </summary>
        public string CalendarName { get; set; } = null!;

        /// <summary>
        /// Get or set the number of entries.
        /// </summary>
        public int NumberEntries { get; set; }
    }
}