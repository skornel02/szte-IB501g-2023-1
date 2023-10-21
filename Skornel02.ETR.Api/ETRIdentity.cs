using System.Security.Claims;

namespace Skornel02.ETR.Api;

public class ETRIdentity : ClaimsIdentity
{
    public override bool IsAuthenticated => true;
    public override string? AuthenticationType => "Bearer";
    public string Username {get; private set;}
    
    public ETRIdentity(string username)
    {
        Username = username;
        AddClaim(new Claim(ClaimTypes.Name, username));
    }
}

public static class ETRIdentityExtensions
{
    public static ClaimsPrincipal ToClaimsPrinciple(this ETRIdentity identity)
    {
        var principle = new ClaimsPrincipal(identity);

        return principle;
    }

    public static ETRIdentity ToETR(this ClaimsPrincipal principal)
    {
        if (principal?.Identity?.Name is null)
        {
            throw new ArgumentNullException("Invalid claims principal!");
        }

        return new ETRIdentity(principal.Identity.Name);
    }
}