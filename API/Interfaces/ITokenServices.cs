using API.Entities;

namespace API.Interfaces
{
    public class ITokenServices
    {
        string CreateToken(AppUser user);
    }
}