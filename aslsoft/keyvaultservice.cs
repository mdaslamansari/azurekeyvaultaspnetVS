using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace aslsoft
{
    public static class keyvaultservice
    {
        public static string dbconnection { get; set; }

        public static async Task<string> GetToken(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            ClientCredential clientcred = new ClientCredential(System.Configuration.ConfigurationManager.AppSettings["ClientId"], System.Configuration.ConfigurationManager.AppSettings["ClientSecret"]);
            AuthenticationResult result = await authContext.AcquireTokenAsync(resource, clientcred);
            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain token");

            }
            return result.AccessToken;
        }
    }
}
