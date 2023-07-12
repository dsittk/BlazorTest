using System;

namespace Entities.Api
{
    public class AuthenticateRequestApi
    {
        public Guid ApplicationId { get; set; }
        public string Password { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }
}