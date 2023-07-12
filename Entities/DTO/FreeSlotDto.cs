namespace Entities.DTO
{
    public class FreeSlotDto
    {
        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets la date du RDV actuel.
        /// </summary>
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// Gets or sets la distance en mètre.
        /// </summary>
        public double Distance { get; set; }
    }
}