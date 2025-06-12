using Microsoft.AspNetCore.Identity;

namespace cashTracker.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
