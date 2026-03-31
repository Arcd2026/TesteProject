using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace Teste.UserDomain
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}
