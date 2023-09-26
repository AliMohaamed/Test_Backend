using Microsoft.AspNetCore.Identity;

namespace CodePulse_API.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreatJwtToken(IdentityUser user, List<string> roles); 
    }
}
