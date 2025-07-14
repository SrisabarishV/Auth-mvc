using Microsoft.AspNetCore.Identity;

namespace Interface1.Models
{
    public class Users:IdentityUser

    {
        public string FullName { get; set; }
    }

}
