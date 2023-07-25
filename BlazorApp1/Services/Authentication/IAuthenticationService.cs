using Amazon.CognitoIdentityProvider.Model;

namespace BlazorApp1.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<InitiateAuthResponse> SignInAsync(string username, string password);
    }
}
