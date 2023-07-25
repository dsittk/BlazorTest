using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using System.Threading.Tasks;

namespace BlazorApp1.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAmazonCognitoIdentityProvider _cognitoProvider;

        public AuthenticationService()
        {
            var awsCredentials = new Amazon.Runtime.BasicAWSCredentials("7oG#0U$dgQcREwT7", "bzlrO8suw1Zrp9P7egsZUf3u+oDpSw8HcfdvkXEs");
            var awsRegion = RegionEndpoint.GetBySystemName("eu-west-3");
            _cognitoProvider = new AmazonCognitoIdentityProviderClient(awsCredentials, awsRegion);
        }

        public async Task<InitiateAuthResponse> SignInAsync(string username, string password)
        {
            var request = new InitiateAuthRequest
            {
                AuthFlow = AuthFlowType.USER_PASSWORD_AUTH,
                ClientId = "5srk8bmqun03uinhf87trju912",
                AuthParameters = new Dictionary<string, string>
            {
                { "USERNAME", username },
                { "PASSWORD", password }
            }
            };

            var response = await _cognitoProvider.InitiateAuthAsync(request);
            return response;
        }
    }
}
