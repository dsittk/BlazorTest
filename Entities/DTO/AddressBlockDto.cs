using System;

namespace Entities.DTO
{
    public class AddressBlockDto
    {
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? City { get; set; }
        public string? Company { get; set; }
        public string? FirstName { get; set; }
        public Guid Id { get; set; }
        public string? LastName { get; set; }
        public string? PostalCode { get; set; }
    }
}