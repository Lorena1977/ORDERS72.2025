using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Orders72.Frontend.AuthenticationProviders
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();//Defino anonimous como una reclamación de Identidad
            var user = new ClaimsIdentity(authenticationType: "test");
            var admin = new ClaimsIdentity(new List<Claim>
    {
        new Claim("FirstName", "Juan"),
        new Claim("LastName", "Zulu"),
        new Claim(ClaimTypes.Role, "Admin")
    },
    authenticationType: "test");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(admin)));
        }
    }

}
