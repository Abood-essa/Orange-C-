using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Identity_Implementation.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

    }
}
