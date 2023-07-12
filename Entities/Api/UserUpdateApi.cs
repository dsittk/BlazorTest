using System.ComponentModel.DataAnnotations;

namespace Entities.Api
{
    public class UserUpdateApi
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}