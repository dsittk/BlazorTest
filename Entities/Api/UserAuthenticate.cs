namespace Entities.Api
{
    public class UserAuthenticate
    {
        public string? Email { get; set; }
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string? Name { get; set; }

        public string Token { get; set; } = null!;
        public string? UserName { get; set; }
    }
}