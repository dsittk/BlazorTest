namespace Entities.Api
{
    public class UserApi
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public string? Email { get; set; }
    }
}